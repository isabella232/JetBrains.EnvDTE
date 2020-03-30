using System.Linq;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Host.Features.ProjectModel.View;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.CSharp.Impl;
using JetBrains.ReSharper.Psi.CSharp.Tree;
using JetBrains.Rider.Model;

namespace JetBrains.EnvDTE.Host.Callback.Impl
{
    [SolutionComponent]
    public sealed class CodeElementCallbackProvider : IEnvDteCallbackProvider
    {
        public void RegisterCallbacks(
            ConnectionManager connectionManager,
            ISolution solution,
            ProjectModelViewHost host,
            DteProtocolModel model
        )
        {
            model.CodeElement_get_Children.SetWithReadLock(codeElementModel =>
            {
                var astManager = connectionManager.AstManagers[codeElementModel.ContainingFile.Id];
                var query =
                    from childId in astManager.GetChildren(codeElementModel.Id)
                    let child = astManager.GetElement(childId)
                    let childTypeId = PsiElementRegistrar.GetTypeId(child)
                    select new CodeElementModel(childTypeId, codeElementModel.ContainingFile, childId);
                return query.ToList();
            });
            model.CodeElement_get_Access.SetWithReadLock(codeElementModel =>
            {
                var astManager = connectionManager.AstManagers[codeElementModel.ContainingFile.Id];
                var node = astManager.GetElement(codeElementModel.Id);
                if (!(node is IAccessRightsOwner @class)) return Access.None;
                return @class.GetAccessRights() switch {
                    AccessRights.PUBLIC => Access.Public,
                    AccessRights.INTERNAL => Access.Internal,
                    AccessRights.PROTECTED => Access.Protected,
                    AccessRights.PROTECTED_OR_INTERNAL => Access.ProtectedInternal,
                    AccessRights.PROTECTED_AND_INTERNAL => Access.ProtectedInternal,
                    AccessRights.PRIVATE => Access.Private,
                    _ => Access.None
                };
            });
            model.CodeElement_get_Name.SetWithReadLock(codeElementModel =>
            {
                var astManager = connectionManager.AstManagers[codeElementModel.ContainingFile.Id];
                var element = astManager.GetElement(codeElementModel.Id);
                return ElementNameProvider.FindName(element);
            });
            model.CodeElement_get_FullName.SetWithReadLock(codeElementModel =>
            {
                var astManager = connectionManager.AstManagers[codeElementModel.ContainingFile.Id];
                var element = astManager.GetElement(codeElementModel.Id);
                if (!(element is ICSharpDeclaration node)) return null;
                return CSharpSharedImplUtil.GetQualifiedName(node);
            });
        }
    }
}

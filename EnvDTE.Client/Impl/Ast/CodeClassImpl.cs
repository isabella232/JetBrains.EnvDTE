using System;
using EnvDTE;
using EnvDTE80;

namespace JetBrains.EnvDTE.Client.Impl.Ast
{
    public sealed class CodeClassImpl : CodeClass2
    {
        public DTE DTE => throw new NotImplementedException();
        public CodeElements Collection => throw new NotImplementedException();

        public string Name
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public string FullName => throw new NotImplementedException();
        public ProjectItem ProjectItem => throw new NotImplementedException();
        public vsCMElement Kind => throw new NotImplementedException();
        public bool IsCodeType => throw new NotImplementedException();
        public vsCMInfoLocation InfoLocation => throw new NotImplementedException();
        public CodeElements Children => throw new NotImplementedException();
        public string Language => throw new NotImplementedException();
        public TextPoint StartPoint => throw new NotImplementedException();
        public TextPoint EndPoint => throw new NotImplementedException();
        public object ExtenderNames => throw new NotImplementedException();
        public string ExtenderCATID => throw new NotImplementedException();
        public object Parent => throw new NotImplementedException();
        public CodeNamespace Namespace => throw new NotImplementedException();
        public CodeElements Bases => throw new NotImplementedException();
        public CodeElements Members => throw new NotImplementedException();

        public vsCMAccess Access
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public CodeElements Attributes => throw new NotImplementedException();

        public string DocComment
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public string Comment
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public CodeElements DerivedTypes => throw new NotImplementedException();
        public CodeElements ImplementedInterfaces => throw new NotImplementedException();

        public bool IsAbstract
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public vsCMClassKind ClassKind
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public CodeElements PartialClasses => throw new NotImplementedException();

        public vsCMDataTypeKind DataTypeKind
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public CodeElements Parts => throw new NotImplementedException();

        public vsCMInheritanceKind InheritanceKind
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public bool IsGeneric => throw new NotImplementedException();

        public bool IsShared
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        object CodeClass.get_Extender(string ExtenderName) => throw new NotImplementedException();
        TextPoint CodeClass2.GetStartPoint(vsCMPart Part) => throw new NotImplementedException();
        TextPoint CodeClass2.GetEndPoint(vsCMPart Part) => throw new NotImplementedException();
        CodeElement CodeClass2.AddBase(object Base, object Position) => throw new NotImplementedException();

        CodeAttribute CodeClass2.AddAttribute(string Name, string Value, object Position) =>
            throw new NotImplementedException();

        void CodeClass2.RemoveBase(object Element) => throw new NotImplementedException();
        void CodeClass2.RemoveMember(object Element) => throw new NotImplementedException();
        bool CodeClass2.get_IsDerivedFrom(string FullName) => throw new NotImplementedException();

        CodeInterface CodeClass2.AddImplementedInterface(object Base, object Position) =>
            throw new NotImplementedException();

        CodeFunction CodeClass2.AddFunction(string Name, vsCMFunction Kind, object Type, object Position,
            vsCMAccess Access, object Location) =>
            throw new NotImplementedException();

        CodeVariable CodeClass2.AddVariable(string Name, object Type, object Position,
            vsCMAccess Access, object Location) =>
            throw new NotImplementedException();

        CodeProperty CodeClass2.AddProperty(string GetterName, string PutterName, object Type, object Position,
            vsCMAccess Access, object Location) =>
            throw new NotImplementedException();

        CodeClass CodeClass2.AddClass(string Name, object Position, object Bases, object ImplementedInterfaces,
            vsCMAccess Access) =>
            throw new NotImplementedException();

        CodeStruct CodeClass2.AddStruct(string Name, object Position, object Bases, object ImplementedInterfaces,
            vsCMAccess Access) =>
            throw new NotImplementedException();

        CodeEnum CodeClass2.AddEnum(string Name, object Position, object Bases, vsCMAccess Access) =>
            throw new NotImplementedException();

        CodeDelegate CodeClass2.AddDelegate(string Name, object Type, object Position, vsCMAccess Access) =>
            throw new NotImplementedException();

        void CodeClass2.RemoveInterface(object Element) => throw new NotImplementedException();

        public CodeEvent AddEvent(string Name, string FullDelegateName, bool CreatePropertyStyleEvent = false,
            object Location = null,
            vsCMAccess Access = vsCMAccess.vsCMAccessDefault) =>
            throw new NotImplementedException();

        object CodeClass2.get_Extender(string ExtenderName) => throw new NotImplementedException();
        TextPoint CodeClass.GetStartPoint(vsCMPart Part) => throw new NotImplementedException();
        TextPoint CodeClass.GetEndPoint(vsCMPart Part) => throw new NotImplementedException();
        CodeElement CodeClass.AddBase(object Base, object Position) => throw new NotImplementedException();

        CodeAttribute CodeClass.AddAttribute(string Name, string Value, object Position) =>
            throw new NotImplementedException();

        void CodeClass.RemoveBase(object Element) => throw new NotImplementedException();
        void CodeClass.RemoveMember(object Element) => throw new NotImplementedException();
        bool CodeClass.get_IsDerivedFrom(string FullName) => throw new NotImplementedException();

        CodeInterface CodeClass.AddImplementedInterface(object Base, object Position) =>
            throw new NotImplementedException();

        CodeFunction CodeClass.AddFunction(string Name, vsCMFunction Kind, object Type, object Position,
            vsCMAccess Access, object Location) =>
            throw new NotImplementedException();

        CodeVariable CodeClass.AddVariable(string Name, object Type, object Position,
            vsCMAccess Access, object Location) =>
            throw new NotImplementedException();

        CodeProperty CodeClass.AddProperty(string GetterName, string PutterName, object Type, object Position,
            vsCMAccess Access, object Location) =>
            throw new NotImplementedException();

        CodeClass CodeClass.AddClass(string Name, object Position, object Bases, object ImplementedInterfaces,
            vsCMAccess Access) =>
            throw new NotImplementedException();

        CodeStruct CodeClass.AddStruct(string Name, object Position, object Bases, object ImplementedInterfaces,
            vsCMAccess Access) =>
            throw new NotImplementedException();

        CodeEnum CodeClass.AddEnum(string Name, object Position, object Bases, vsCMAccess Access) =>
            throw new NotImplementedException();

        CodeDelegate CodeClass.AddDelegate(string Name, object Type, object Position, vsCMAccess Access) =>
            throw new NotImplementedException();

        void CodeClass.RemoveInterface(object Element) => throw new NotImplementedException();
    }
}

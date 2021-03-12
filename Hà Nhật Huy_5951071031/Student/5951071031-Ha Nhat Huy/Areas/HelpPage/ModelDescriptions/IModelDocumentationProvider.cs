using System;
using System.Reflection;

namespace _5951071031_Ha_Nhat_Huy.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}
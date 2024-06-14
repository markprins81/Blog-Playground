using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;
using System.Reflection;

namespace Foundation.CmsPlugin
{
    public class MyEmbeddedFileProvider : IFileProvider
    {
        private readonly Assembly _assembly;

        private string _assemblyName => _assembly.GetName().Name;

        public MyEmbeddedFileProvider(Assembly assembly)
        {
            _assembly = assembly;
        }   

        public IDirectoryContents GetDirectoryContents(string subpath)
        {
            var rv = new EmbeddedFileProvider(_assembly).GetDirectoryContents(subpath);
            return rv;
        }

        public IFileInfo GetFileInfo(string subpath)
        {
            if (subpath.StartsWith("/"))
            {
                subpath = subpath.Substring(1);
            }

            if (!subpath.StartsWith(_assemblyName))
            {
                return new NotFoundFileInfo(subpath);
            }

            subpath = subpath.Substring(_assemblyName.Length + 1);

            var rv = new EmbeddedFileProvider(_assembly).GetFileInfo(subpath);
            return rv;
        }

        public IChangeToken Watch(string filter)
        {
            var rv = new EmbeddedFileProvider(_assembly).Watch(filter);
            return rv;
        }
    }
}

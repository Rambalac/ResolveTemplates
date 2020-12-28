using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolveTemplates
{
    public class MainViewModel
    {
        public List<Template> Templates { get; set; } = new();

        public List<string> Files { get; set; } = new();

        public IEnumerable<string> FileNames => Files.Select(f => Path.GetFileName(f));

        public Template SelectedTemplate { get; set; }

        public void AddFiles(string[] files)
        {
            Files.AddRange(files);
        }
    }
}

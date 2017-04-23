using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vHostEditor
{
    class VirtualHostEntry
    {
        public String DocumentRoot { get; set; }

        public String ServerName { get; set; }
        public String ServerAlias { get; set; }
        
        public String BaseDirectory { get; set; }


        public override string ToString()
        {
            return String.Format("\n\n<VirtualHost *:80>\n\tDocumentRoot \"{0}/\"\n\tServerName {1}\n\tServerAlias {2}\n\t<Directory \"{3}\">\n\t\tOrder allow,deny\n\t\tAllow from all\n\t\tRequire all granted\n\t</Directory>\n</VirtualHost>",
                DocumentRoot, ServerName, ServerAlias, BaseDirectory);
        }
    }
}

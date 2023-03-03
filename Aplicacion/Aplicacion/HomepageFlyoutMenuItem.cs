using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class HomepageFlyoutMenuItem
    {
        public HomepageFlyoutMenuItem()
        {
            TargetType = typeof(HomepageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }

        public string IconSource { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgextGibdd.Entities;

namespace ProgextGibdd.Utilities
{
    internal class DBContext
    {
        private static Gibdd_MamichevEntities _context { get; set; }

        public static Gibdd_MamichevEntities Context
        {
            get
            {
                if( _context == null )
                    _context = new Gibdd_MamichevEntities();
                return _context;
            }
        }
    }
}

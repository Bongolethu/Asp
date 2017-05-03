using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace TheProject.core.Entity
{
    /// <summary>
    /// This is View model is to structure the 
    /// </summary>
    public class TreeViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<TreeViewModel> Children { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    internal class Status
    {
        /*Status class
- Id  
- Title
- Content*/
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        /*- SharedDate - DateTime tipindən bir property, statusdan yeni bir obyekt yaranan zaman yarandığı tarix set olunacaq.
*/      private DateTime _shareddata;
        public DateTime SharedDate { get { return _shareddata; } set {  } }



    }
}

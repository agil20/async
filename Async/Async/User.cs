using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    internal class User
    {



        /*- Id
       - Statuses - status obyektlərini özündə saxlayan bir list olacaq.
       - Username
       - ShareStatus() - parametr olaraq bir status obyekti qəbul edib statuses listinə əlavə edəcək.*/
        public int Id { get; set; }
        List<Status> Statuses;
        public User()
        {
            Statuses = new List<Status>();
        }

        public void ShareStatus(Status status)
        {

            Statuses.Add(status);   
        }
        /*- GetStatusById() - parametr olaraq nullable int tipindən bir id qəbul 
         * edəcək həmin id-li statusu tapıb geriyə qaytaracaq.*/
        public void GetStatusById(int ? id)
        {
            foreach (var item in Statuses)
            {
                if (id==item.Id)
                {
                    item.GetStatusInfo();
                }

            }

        }
        /*- GetAllStatuses() - geriyə user-in bütün statuslarını qaytaracaq.*/
        public void GetAllStatuses()
        {
            foreach (var item in Statuses)
            {
                //Statuses.Find(id => id == item.id);
            }
            /**MyClass result = list.First(m => m.GetId() == id); */
           
        }
        /*- FilterStatusByDate() - parametr olaraq bir nullable id və DateTime tipindən bir tarix qəbul edəcək göndərilən
    id-li user-in həmin tarixdən sonra paylaşılan bütün statuslarını geriyə qaytaracaq, 
         * göndərilən tarixdən sonra heç bir status paylaşılmayıbsa NotFoundException baş verəcək.*/
            public void FilterStatusByDate(int ? id , DateTime date)
        { date= DateTime.Now;

            foreach (var item in Statuses)
            {
                if (date>item.SharedDate)
                {
                    item.GetStatusInfo();

                }

            }
           
        } 





    }
}

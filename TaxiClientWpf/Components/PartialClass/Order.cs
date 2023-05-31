using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiClientWpf.Components 
{
    public partial class Order
    {
      public  string Status
        {
            get
            {
                if (IsAccept == null)
                {
                    return "В обработке";
                }
                else if(IsAccept == 1)
                {
                    return "Подтвержден оператором";
                }
                else if (IsAccept == 2)
                {
                    return "Принят водителем";
                }
              
                    return "в обработке";
                
            }
        }
        }
        }
    


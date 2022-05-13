using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyV4._1.Models;

namespace VidlyV4._1.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}
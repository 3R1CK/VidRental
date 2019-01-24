using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using VidRental.Models;

namespace VidRental.ViewModel
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}
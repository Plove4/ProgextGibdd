//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProgextGibdd.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Drivers
    {
        public int ID { get; set; }
        public string SurName { get; set; }
        public string Name { get; set; }
        public string MiddlName { get; set; }
        public string Passport { get; set; }
        public Nullable<int> Postcode { get; set; }
        public string Address { get; set; }
        public string Address_life { get; set; }
        public string JobName { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }

        public string ImagePath
        {
            get
            {
                return "../Resources/photo/" + this.Photo;
            }
        }
    }
}
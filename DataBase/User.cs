//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnessAssistant_ZeynetdinovArtuhov_2ISP11_17.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public System.DateTime Birthday { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public Nullable<decimal> Age { get; set; }
        public int IDGender { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public byte[] Photo { get; set; }
    
        public virtual Gender Gender { get; set; }
    }
}

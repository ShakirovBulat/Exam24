//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhoneShop.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clients
    {
        public int Id_Client { get; set; }
        public string Login { get; set; }
        public int Id_Phone { get; set; }
        public int Id_User { get; set; }
    
        public virtual Phones Phones { get; set; }
        public virtual User User { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kontragent
{
    using System;
    using System.Collections.Generic;
    
    public partial class YourL
    {
        public int ID { get; set; }
        public string INN { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string E_mail { get; set; }
        public int IDMenager { get; set; }
    
        public virtual Menager Menager { get; set; }
    }
}

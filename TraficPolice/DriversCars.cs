//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TraficPolice
{
    using System;
    using System.Collections.Generic;
    
    public partial class DriversCars
    {
        public int idDriver { get; set; }
        public string idCar { get; set; }
        public Nullable<System.DateTime> dateStartDrive { get; set; }
        public Nullable<System.DateTime> dateEndDrive { get; set; }
    
        public virtual Car Car { get; set; }
        public virtual Driver Driver { get; set; }
    }
}

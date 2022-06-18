using System.Collections.Generic;

namespace EsinavUygulamasi.Models.Request
{
    public class GetListResponseVM<T> : ResponseVM where T : class
    {
        /// <summary>
        /// dönecek obje listesi
        /// </summary>
        public List<T> ObjectList { get; set; }=new List<T>();
    }
}

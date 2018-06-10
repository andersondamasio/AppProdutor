using System.Collections.Generic;

namespace com.datacoper.appprodutor.Dto.Result
{
    public class ResultDto<T>
    {
        public int count { get; set; } = 0;
        public List<T> results { get; set; }
    }
}

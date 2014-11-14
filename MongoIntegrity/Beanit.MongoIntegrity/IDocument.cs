using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beanit.MongoIntegrity
{
    public interface IDocument<TIdentifer>
    {
        TIdentifer Id { get; set; }
    }
}

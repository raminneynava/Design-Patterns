using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Prototype
{
    public interface IPrototype
    {

    }

    public interface IcloneAble<out T> where T : class
    {

        T ShallowCopy();

        T DeepCopy();
    }

    public class LargeObject : IcloneAble<LargeObject>
    {
        public string Id { get; set; }
        public string title { get; set; }
        public InerClass InerClass { get; set; }

        public LargeObject DeepCopy()
        {
            var json=JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<LargeObject>(json);
        }

        public LargeObject ShallowCopy()
        {
            return (LargeObject) MemberwiseClone();
        }
    }
    public class InerClass
    {
        public string Text { get; set; }
    }
}

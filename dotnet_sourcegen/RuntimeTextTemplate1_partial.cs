using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_sourcegen
{
    public partial class RuntimeTextTemplate1
    {
        Type _Type;
        public RuntimeTextTemplate1(Type data)
        {
            _Type = data;
            
        }

        public string ClassName { get
            {
                return _Type.Name;
            }
        }

        public PropertyInfo[] PublicProperties => _Type.GetProperties(BindingFlags.Instance | BindingFlags.Public);

        // 設計内容をコードに変換する処理を書いたりする
        public string GetName(Type data) {
            return $"{data.Name}";
        }
    }
}

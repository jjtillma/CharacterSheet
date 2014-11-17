using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheetManager.Models
{
    public abstract class ModelBase: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            Type type = this.GetType();
            PropertyInfo[] info = type.GetProperties();
            List<object> values = new List<object>();
            Array.CreateInstance(typeof(object), info.Length);

            foreach(PropertyInfo item in info)
            {
                values.Add(item.GetValue(this));
            }

            string returnString = this.GetType().Name + ":";
            for(int i = 0; i < info.Length; i++)
            {
                returnString = returnString + info[i].Name + "=" + values[i].ToString() +",";
            }
            returnString = returnString + "\n";
            return returnString;
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}

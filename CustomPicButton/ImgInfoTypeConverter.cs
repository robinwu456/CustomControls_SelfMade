using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;

namespace CustomPicButton {
    public class ImgInfoTypeConverter : TypeConverter {
        /// <summary>
        /// 是否在屬性視窗中顯示類別的屬性
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override bool GetPropertiesSupported(ITypeDescriptorContext context) {
            //return base.GetPropertiesSupported(context);
            return true;
        }

        /// <summary>
        /// 取得類別的屬性，轉換成屬性視窗可以顯示的物件
        /// </summary>
        /// <param name="context"></param>
        /// <param name="value"></param>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) {
            //return base.GetProperties(context, value, attributes);
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(value, attributes);
            return properties;
        }

        /// <summary>
        /// 是否支援ConvertFrom的功能
        /// 將屬性視窗內的資訊轉換成類別
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) {
            //return base.CanConvertFrom(context, sourceType);
            if (sourceType == typeof(string))
                return true;
            else if (sourceType == typeof(DateTime))
                return true;
            else if (sourceType == typeof(Image))
                return true;

            return base.CanConvertFrom(context, sourceType);
        }

        /// <summary>
        /// 將屬性視窗內的資訊轉換成類別
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) {
            //return base.ConvertFrom(context, culture, value);
            if (value is string)    //屬性視窗內的該類別統一後的資訊是否為string
            {
                //string[] v = ((string)value).Split(new char[] { ';' }); //利用分隔符號，將字串拆成字串陣列

                //UserInfo  m_user = new UserInfo ();

                //if (v.Length == 3)          //依照順序，填入UserInfo類別中對應的屬性中
                //{
                //    m_user.UserName = v[0];                     //UserName
                //    m_user.BirthPlace = v[1];                   //BirthPlace
                //    m_user.BirthDay = DateTime.Parse(v[2]);     //BirthDay。由於UserInfo中此屬性屬於DateTime型別，故需要將字串轉換成DateTime格式
                //}
                //return m_user;
                return null;
            } else if (value is ImgInfo)
                return value as ImgInfo;
            else
                return base.ConvertFrom(context, culture, value);
        }

        /// <summary>
        /// 是否支援ConvertTo的功能
        /// 將類別轉換成屬性視窗中相對應屬性的型別
        /// </summary>
        /// <param name="context"></param>
        /// <param name="destinationType"></param>
        /// <returns></returns>
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) {
            //return base.CanConvertTo(context, destinationType);
            if (destinationType == typeof(ImgInfo))
                return true;

            return base.CanConvertTo(context, destinationType);
        }

        /// <summary>
        /// 將類別轉換成屬性視窗中相對應屬性的型別
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <param name="destinationType"></param>
        /// <returns></returns>
        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType) {
            //return base.ConvertTo(context, culture, value, destinationType);
            if (destinationType == typeof(string))                  //屬性視窗中此類別屬性為字串
            {
                //UserInfo user = (UserInfo)value;                    //將傳入值轉型成UserInfo

                //if (culture == null)
                //    culture = System.Globalization.CultureInfo.CurrentCulture;

                //string[] values = new string[3];                                //宣告字串陣列，並將UserInfo類列屬性依順序擺放至字串陣列
                //values[0] = user.UserName;
                //values[1] = user.BirthPlace;
                //values[2] = user.BirthDay.Date.ToShortDateString();

                //return String.Join(";", values);                    //將字串陣列轉換成有分隔符號；的一組字串
                return base.ConvertTo(context, culture, value, destinationType);
            } else if (destinationType == typeof(ImgInfo)) {
                //ImgInfo imgInfo = value as ImgInfo;

                //if (culture == null)
                //    culture = System.Globalization.CultureInfo.CurrentCulture;

                //string[] values = new string[3];                                //宣告字串陣列，並將UserInfo類列屬性依順序擺放至字串陣列
                //values[0] = imgInfo.BackImg_Disabled.;
                //values[1] = imgInfo.BirthPlace;
                //values[2] = imgInfo.BirthDay.Date.ToShortDateString();

                //return String.Join(";", values);                    //將字串陣列轉換成有分隔符號；的一組字串
                return base.ConvertTo(context, culture, value, destinationType);
            } else
                return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaxiDispatcher.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TaxiDispatcher.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на directions/v2/optimizedroute.
        /// </summary>
        internal static string API_MQUEST_OPTIMROUT {
            get {
                return ResourceManager.GetString("API_MQUEST_OPTIMROUT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на aSkEHOECH4d1c9OlCUxAq1uQfnc7WL30.
        /// </summary>
        internal static string MAPQUEST_API_KEY {
            get {
                return ResourceManager.GetString("MAPQUEST_API_KEY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на R7WSxbeISJASLADkPPnPkkTrhMyVV6biKH16YKuU.
        /// </summary>
        internal static string OSM_API_KEY {
            get {
                return ResourceManager.GetString("OSM_API_KEY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на http://open.mapquestapi.com/.
        /// </summary>
        internal static string UPL_MAPQUEST_API {
            get {
                return ResourceManager.GetString("UPL_MAPQUEST_API", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на http://api.openstreetmap.org/.
        /// </summary>
        internal static string URL_OSM_API {
            get {
                return ResourceManager.GetString("URL_OSM_API", resourceCulture);
            }
        }
    }
}

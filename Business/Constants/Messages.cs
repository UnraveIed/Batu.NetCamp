using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok";
        internal static string UserRegistered = "Eklendi";
        internal static string UserNotFound = "Kullanıcı adı hatalı";
        internal static string PasswordError = "Yanlış password";
        internal static string SuccessfulLogin = "Başarılı giriş";
        internal static string UserAlreadyExists = "Bu isimde kullanıcı mevcut";
        internal static string AccessTokenCreated = "Token oluşturuldu";
        internal static string ProductUpdated;
    }
}

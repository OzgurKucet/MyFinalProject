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
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Ürün sayısı 10 dan büyük olamaz";
        public static string TheSameNameError = "Ürün baska bir ürün ile aynı isimde olamaz.";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "Kayıt oldu";

        public static string UserNotFound = "Kullanıcı bulunamadı";

        public static string PasswordError = "Parola Hatasi";

        public static string SuccessfulLogin = "Basarili giris";

        public static string UserAlreadyExists = "Kullanici Mevcut";

        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}

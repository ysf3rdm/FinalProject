using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameİnvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem Bakımda.";
        public static string ProductsListed = "Ürünler Listelendi.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde bir ürün zaten var";
        public static string CategoryLimitExceded = "kategori limiti aşıldı";
        public static string AuthorizationDenied = "Giriş Reddedildi";
        public static string UserRegistered="Kullanıcı kaydoldu";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="şifre hatası";
        public static string SuccessfulLogin="başarılı giriş";
        public static string UserAlreadyExists="kullanıcı zaten var";
        public static string AccessTokenCreated="erişim oluşturuldu";
    }
}

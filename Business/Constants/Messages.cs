using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductNameInvalidAdd = "Araba ismi minimum 2 karakter uzunluğunda olmalıdır.";
        public static string CarDateInvalidAdd = "Kiralamak istediğiniz araba henüz teslim edilmemiştir.";
        public static string CarRentSuccess = "Arabanızın keyfini çıkarın.";
        public static string CarImageUpdated = "Araba resimleri güncellendi.";
        public static string CarImageLimitExceeded = "Bir arabanın en fazla 5 resmi olabilir.";
        public static string CarImageDeleted = "Araba resimleri silindi";
        public static string CarImageAdded = "Araba resimleri eklendi";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string ClaimsListed="Claimler listelendi.";
        public static string PasswordError = "Şifre hatalı";
        public static string LoginSuccessful = "Giriş başarılı";
        public static string RegisterSuccessful="Kullanıcı başarıyla kaydedildi.";

        public static string UserAlreadyExists = "ula uşağım zaten varsin ya sen";
    }
}

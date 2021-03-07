using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Car Added";
        public static string CarPriceInvalid = "Daily car rental fee should be more than 0!!!";
        public static string CarDeleted = "Car Deleted";
        public static string CarUpdated = "Car Updated";
        public static string MaintenanceTime = "The system is under maintenance.";
        public static string CarsListed = "Cars Listed";
        public static string BrandAdded = "Brand name added";
        public static string BrandNameInvalid= "The car brand name must contain at least 2 characters!!!";
        public static string BrandDeleted="Brand Deleted";
        public static string BrandUpdated="Brand Updated";
        public static string ColorAdded="Color Added";
        public static string ColorDeleted="Color Deleted";
        public static string ColorUpdated="Color Updated";
        public static string UserAdded="User Added";
        public static string UserDeleted="User Deleted";
        public static string UserUpdated="User Updated";
        public static string CustomerAdded="Customer Added";
        public static string CarIdInvalid="The car id is invalid!!!";
        public static string RentalAdded= "There is space available.";
        public static string RentalNotEmpty= "There is no space available.";
        public static string RentalsListed="Rentals Listed";
        public static string RentalUpdated="Rentals Updated";
        public static string BrandsListed="Brands Listed";
        public static string CustomerDeleted= "Customer Deleted";
        public static string CustomerUpdated= "Customer Updated";
        public static string CarInUse="Car In Use";
        public static string CarImageAddInvalid="No Car Image Added";
        public static string CarImageAdded="Car Image Added";
        public static string CarImageDeleted="Car Image Deleted";
        public static string AuthorizationDenied= "Authorization Denied";
        public static string UserRegistered="User Registered";
        public static string AccessTokenCreated= "Access Token Created";
        public static string UserAlreadyExists= "User Alread yExists";
        public static string SuccessfulLogin= "Successful Login";
        public static string PasswordError= "Password Error";
        public static string UserNotFound= "User Not Found";
    }
}

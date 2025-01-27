﻿using Utilities.Core.UtilityApplication.VMs;

namespace GCard.Application.VMs
{
    public class MobileRelatedListByStaffIdVM:BaseVM
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfilePicturePath { get; set; }
        public List<IbanVM>? Ibans { get; set; }
        public List<PhoneNumberVM>? PhoneNumbers { get; set; }
        public List<StaffFieldVM>? StaffFields { get; set; }
        public List<MobileCustomSocialMediaUrlVM>? SocialMediaUrls { get; set; } 
        public List<StaffFileVM>? Files { get; set; }
    }
}

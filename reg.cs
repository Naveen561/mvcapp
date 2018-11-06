
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Required Field")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Required Field")]
        [Display(Name ="Mobile Number")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Required Field")]
        [Display(Name ="Mail id")]
        public string MailID { get; set; }

        [Required(ErrorMessage = "Required Field")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage ="Required Field")]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        public string ConformPassword { get; set; }
        [Display(Name ="Upload Image")]
        [Required(ErrorMessage = "Required Field")]
        public string Imagepath { get; set; }

        public HttpPostedFileBase ImageFile { get; set; }
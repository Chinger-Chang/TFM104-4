﻿using MVC_Project_220322.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Project_220319.Models
{
    public class Order
    {
        [KeyAttribute]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } //訂單編號

        [Required]
        [MaxLength(10)]
        public string Name { get; set; } //訂購人姓名

        [Required]
        public DateTime Date { get; set; } //購買日期

        public double? Discount { set; get; } //平台折扣

        [Required]
        public OrderStatus OrderStatus { set; get; } //訂單狀態

        //[ForeignKey("Product")] 
        //public int ProductId { get; set; } //商品編號
        ////public Product Product { get; set; }
        //public virtual ICollection<Product> Products { get; set; }     

        //商品跟訂單是多對多關係 所以對到延伸的資料表 訂單明細(一對多)
        public virtual ICollection<Orderdetail> Orderdetails { get; set; }

        //一個使用者會有多個訂單
        [ForeignKey("User")]
        public Guid UserId { get; set; } //使用者編號
        public virtual User User { get; set; }

        //[Required]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal OrderPrice { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class fileone
    {
        public string filetype { get; set; }               //档案类型    
        public string projectUnit { get; set; }                //项目单位
        public string fileId { get; set; }              //案卷号        	
        public string dangId { get; set; }                //档号        	
        public string filename { get; set; }          //问卷题名        	
        public string page { get; set; }              //页数    	
        public string jianId { get; set; }             //件号
        public string anname { get; set; }              //案卷题名
        public string responsible { get; set; }              //责任人
        public string gdmethod { get; set; }                //归档类型
        public string years { get; set; }                //年限    
    }
}

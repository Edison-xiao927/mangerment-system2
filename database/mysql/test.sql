/*
Navicat MySQL Data Transfer

Source Server         : hello
Source Server Version : 50724
Source Host           : localhost:3306
Source Database       : test

Target Server Type    : MYSQL
Target Server Version : 50724
File Encoding         : 65001

Date: 2018-12-29 10:07:06
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `apmoney`
-- ----------------------------
DROP TABLE IF EXISTS `apmoney`;
CREATE TABLE `apmoney` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `p1` int(255) DEFAULT NULL,
  `p2` int(255) DEFAULT NULL,
  `p3` int(255) DEFAULT NULL,
  `cb` int(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of apmoney
-- ----------------------------
INSERT INTO `apmoney` VALUES ('1', '5', '10', '100', '100');
INSERT INTO `apmoney` VALUES ('4', '5', '10', '100', '70');

-- ----------------------------
-- Table structure for `aspunch`
-- ----------------------------
DROP TABLE IF EXISTS `aspunch`;
CREATE TABLE `aspunch` (
  `id` int(255) NOT NULL AUTO_INCREMENT COMMENT '季节',
  `smw` datetime DEFAULT NULL COMMENT '上午上班应打卡时间',
  `sme` datetime DEFAULT NULL COMMENT '上午下班应打卡时间',
  `saw` datetime DEFAULT NULL COMMENT '下午上班应打卡时间',
  `sae` datetime DEFAULT NULL COMMENT '下午下班应打卡时间',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of aspunch
-- ----------------------------
INSERT INTO `aspunch` VALUES ('1', '2018-12-04 08:00:56', '2018-12-04 11:30:01', '2018-12-04 14:00:07', '2018-12-04 17:30:58');
INSERT INTO `aspunch` VALUES ('2', '2018-12-04 08:10:34', '2018-12-04 11:40:42', '2018-12-04 14:00:00', '2018-12-04 17:30:00');
INSERT INTO `aspunch` VALUES ('3', '2018-12-04 08:00:00', '2018-12-04 11:30:00', '2018-12-04 14:00:00', '2018-12-04 17:30:00');
INSERT INTO `aspunch` VALUES ('4', '2018-12-05 08:00:00', '2018-12-05 11:30:00', '2018-12-05 14:00:00', '2018-12-05 16:40:00');
INSERT INTO `aspunch` VALUES ('5', '2018-12-06 08:35:00', '2018-12-06 12:00:00', '2018-12-06 14:30:00', '2018-12-06 17:30:00');
INSERT INTO `aspunch` VALUES ('6', '2018-12-06 08:00:00', '2018-12-06 11:30:00', '2018-12-06 14:00:00', '2018-12-06 17:30:00');

-- ----------------------------
-- Table structure for `attendance`
-- ----------------------------
DROP TABLE IF EXISTS `attendance`;
CREATE TABLE `attendance` (
  `id` int(100) NOT NULL AUTO_INCREMENT,
  `useId` int(20) DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  `morningwork` datetime DEFAULT NULL COMMENT '上午上班打卡',
  `morningend` datetime DEFAULT NULL COMMENT '上午下班打卡',
  `afternoonwork` datetime DEFAULT NULL COMMENT '下午上班打卡',
  `afternoonend` datetime DEFAULT NULL COMMENT '下午下班打卡',
  `mealsupport` int(100) DEFAULT NULL COMMENT '餐补',
  `punish` int(100) DEFAULT NULL COMMENT '设置扣罚金额',
  `allwork` varchar(255) DEFAULT NULL COMMENT '全勤',
  `dc` varchar(255) DEFAULT NULL,
  `username` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of attendance
-- ----------------------------
INSERT INTO `attendance` VALUES ('1', '1', '2018-12-03 00:00:00', '2018-12-03 08:00:13', '2018-12-03 11:30:20', '2018-12-03 14:01:28', '2018-12-03 17:30:36', '44', '4', '是', '2', '123');
INSERT INTO `attendance` VALUES ('2', '1', '2018-12-08 00:00:00', '2018-12-08 10:12:46', null, null, null, null, null, null, null, '123');
INSERT INTO `attendance` VALUES ('3', '1', '2018-12-12 00:00:00', null, null, null, '2018-12-12 17:16:18', '70', '100', '是', '11', '123');
INSERT INTO `attendance` VALUES ('4', '1', '2018-12-17 00:00:00', null, null, '2018-12-17 14:37:22', null, null, null, null, null, '123');

-- ----------------------------
-- Table structure for `fileget`
-- ----------------------------
DROP TABLE IF EXISTS `fileget`;
CREATE TABLE `fileget` (
  `bh` varchar(255) DEFAULT NULL,
  `ID` int(20) NOT NULL AUTO_INCREMENT,
  `projectunit` varchar(20) DEFAULT NULL COMMENT '项目单位',
  `getId` varchar(155) DEFAULT NULL COMMENT '领取批次号',
  `gettime` datetime DEFAULT NULL COMMENT '领取时间',
  `dangId` varchar(155) DEFAULT NULL COMMENT '档号',
  `filetype` varchar(20) DEFAULT NULL COMMENT '档案类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(20) DEFAULT NULL COMMENT '年限',
  `question` varchar(150) DEFAULT NULL COMMENT '问题描述',
  `projectunit2` varchar(20) DEFAULT NULL COMMENT '项目单位2',
  `processunit` varchar(20) DEFAULT NULL COMMENT '加工单位',
  `swapdate` datetime DEFAULT NULL COMMENT '交接日期',
  `swapdate2` datetime DEFAULT NULL,
  `page` int(20) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='档案领取交接单';

-- ----------------------------
-- Records of fileget
-- ----------------------------
INSERT INTO `fileget` VALUES ('1', '5', '国土局', '12-001', '2018-12-20 21:55:51', '12', '文档', '项目', '2', '', '国土局', '是发v都是', '2018-10-25 00:00:00', '2018-12-20 21:55:51', null);
INSERT INTO `fileget` VALUES ('2', '6', '国土局', '12-001', '2018-12-20 21:55:51', '12', '文档', '项目', '2', '', '国土局', '是发v都是', '2018-10-25 00:00:00', '2018-12-20 21:55:51', null);
INSERT INTO `fileget` VALUES ('3', '7', '国土局', '12-002', '2018-12-25 15:14:48', '12', '文档', '项目', '2', '', '国土局', '第三方', '2018-10-25 00:00:00', '2018-12-25 15:14:48', null);
INSERT INTO `fileget` VALUES ('4', '8', '国土局', '12-002', '2018-12-25 15:14:48', '12', '文档', '项目', '2', '', '国土局', '第三方', '2018-10-25 00:00:00', '2018-12-25 15:14:48', null);
INSERT INTO `fileget` VALUES ('1', '9', '4123', '1342-001', '2018-12-25 16:45:29', '1342', '512', '文件', '234', '', '4123', '123', '2018-10-25 00:00:00', '2018-12-25 16:45:29', null);
INSERT INTO `fileget` VALUES ('2', '10', '4123', '1342-001', '2018-12-25 16:45:29', '1342', '512', '文件', '234', '', '4123', '123', '2018-10-25 00:00:00', '2018-12-25 16:45:29', null);
INSERT INTO `fileget` VALUES ('3', '11', '4123', '1342-001', '2018-12-25 16:45:29', '1342', '512', '文件', '234', '', '4123', '123', '2018-10-25 00:00:00', '2018-12-25 16:45:29', null);
INSERT INTO `fileget` VALUES ('1', '12', '4123', '1342-002', '2018-12-25 22:18:46', '1342', '512', '文件', '234', '', '4123', '123', '2018-10-25 00:00:00', '2018-12-25 22:18:46', null);
INSERT INTO `fileget` VALUES ('2', '13', '4123', '1342-002', '2018-12-25 22:18:46', '1342', '512', '文件', '234', '', '4123', '123', '2018-10-25 00:00:00', '2018-12-25 22:18:46', null);
INSERT INTO `fileget` VALUES ('5', '14', '4123', '1342-003', '2018-12-26 11:02:10', '1342', '512', '文件', '234', '', '4123', '123', '2018-10-25 00:00:00', '2018-12-26 11:02:10', null);
INSERT INTO `fileget` VALUES ('6', '15', '4123', '1342-003', '2018-12-26 11:02:10', '1342', '512', '文件', '234', '', '4123', '123', '2018-10-25 00:00:00', '2018-12-26 11:02:10', null);
INSERT INTO `fileget` VALUES ('7', '16', '4123', '1342-004', '2018-12-26 11:08:43', '1342', '512', '文件', '234', '', '4123', '213', '2018-10-25 00:00:00', '2018-12-26 11:08:43', null);
INSERT INTO `fileget` VALUES ('8', '17', '4123', '1342-004', '2018-12-26 11:08:43', '1342', '512', '文件', '234', '', '4123', '213', '2018-10-25 00:00:00', '2018-12-26 11:08:43', null);
INSERT INTO `fileget` VALUES ('11', '18', '4123', '1342-005', '2018-12-26 11:19:33', '1342', '512', '文件', '234', '', '4123', '132', '2018-10-25 00:00:00', '2018-12-26 11:19:33', null);
INSERT INTO `fileget` VALUES ('12', '19', '4123', '1342-005', '2018-12-26 11:19:33', '1342', '512', '文件', '234', '', '4123', '132', '2018-10-25 00:00:00', '2018-12-26 11:19:33', null);
INSERT INTO `fileget` VALUES ('13', '20', '4123', '1342-006', '2018-12-26 11:22:10', '1342', '512', '文件', '234', '', '4123', '123', '2018-10-25 00:00:00', '2018-12-26 11:22:10', null);
INSERT INTO `fileget` VALUES ('14', '21', '4123', '1342-006', '2018-12-26 11:22:10', '1342', '512', '文件', '234', '', '4123', '123', '2018-10-25 00:00:00', '2018-12-26 11:22:10', null);
INSERT INTO `fileget` VALUES ('1', '22', '123', '45634-001', '2018-12-26 11:34:54', '45634', '123', '项目', '123', '', '123', '', '2018-10-25 00:00:00', '2018-12-26 11:34:54', null);

-- ----------------------------
-- Table structure for `filegetgh`
-- ----------------------------
DROP TABLE IF EXISTS `filegetgh`;
CREATE TABLE `filegetgh` (
  `projectunit` varchar(20) DEFAULT NULL COMMENT '项目单位',
  `getId` int(20) DEFAULT NULL COMMENT '领取批次号',
  `gettime` datetime DEFAULT NULL COMMENT '领取时间',
  `dangId` int(20) NOT NULL COMMENT '档号',
  `filetype` varchar(20) DEFAULT NULL COMMENT '档案类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(20) DEFAULT NULL COMMENT '年限',
  `question` varchar(150) DEFAULT NULL COMMENT '问题描述',
  `projectunit2` varchar(20) DEFAULT NULL COMMENT '项目单位2',
  `processunit` varchar(20) DEFAULT NULL COMMENT '加工单位',
  `swapdate` datetime DEFAULT NULL COMMENT '交接日期',
  `swapdate2` datetime DEFAULT NULL,
  PRIMARY KEY (`dangId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='档案领取交接单';

-- ----------------------------
-- Records of filegetgh
-- ----------------------------

-- ----------------------------
-- Table structure for `fileproblem`
-- ----------------------------
DROP TABLE IF EXISTS `fileproblem`;
CREATE TABLE `fileproblem` (
  `projectunit` varchar(20) DEFAULT NULL COMMENT '项目单位',
  `getId` varchar(255) DEFAULT NULL COMMENT '领取批次号',
  `gettime` datetime DEFAULT NULL COMMENT '领取时间',
  `dangtype` varchar(20) DEFAULT NULL COMMENT '归档类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(200) DEFAULT NULL COMMENT '年限',
  `ID` int(255) NOT NULL AUTO_INCREMENT COMMENT '档号',
  `problem` varchar(150) DEFAULT NULL COMMENT '问题描述',
  `solve` varchar(150) DEFAULT NULL COMMENT '解决方案',
  `projectunit2` varchar(20) DEFAULT NULL COMMENT '项目单位2',
  `swapdate` datetime DEFAULT NULL COMMENT '加工单位',
  `swapdate2` datetime DEFAULT NULL COMMENT '日期',
  `processunit` varchar(20) DEFAULT NULL,
  `flag` varchar(20) DEFAULT NULL,
  `status1` varchar(20) DEFAULT NULL,
  `page` int(20) DEFAULT NULL,
  `paged` int(20) DEFAULT NULL,
  `bh` varchar(150) DEFAULT NULL,
  `pId` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='档案问题确认单';

-- ----------------------------
-- Records of fileproblem
-- ----------------------------

-- ----------------------------
-- Table structure for `fileproblem10`
-- ----------------------------
DROP TABLE IF EXISTS `fileproblem10`;
CREATE TABLE `fileproblem10` (
  `projectunit` varchar(20) DEFAULT NULL COMMENT '项目单位',
  `getId` int(20) DEFAULT NULL COMMENT '领取批次号',
  `gettime` datetime DEFAULT NULL COMMENT '领取时间',
  `dangtype` varchar(20) DEFAULT NULL COMMENT '归档类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(200) DEFAULT NULL COMMENT '年限',
  `ID` int(255) NOT NULL AUTO_INCREMENT COMMENT '档号',
  `problem` varchar(150) DEFAULT NULL COMMENT '问题描述',
  `solve` varchar(150) DEFAULT NULL COMMENT '解决方案',
  `projectunit2` varchar(20) DEFAULT NULL COMMENT '项目单位2',
  `swapdate` datetime DEFAULT NULL COMMENT '加工单位',
  `swapdate2` datetime DEFAULT NULL COMMENT '日期',
  `processunit` varchar(20) DEFAULT NULL,
  `flag` varchar(20) DEFAULT NULL,
  `status1` varchar(20) DEFAULT NULL,
  `page` int(20) DEFAULT NULL,
  `paged` int(20) DEFAULT NULL,
  `bh` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='档案问题确认单';

-- ----------------------------
-- Records of fileproblem10
-- ----------------------------

-- ----------------------------
-- Table structure for `fileproblem2`
-- ----------------------------
DROP TABLE IF EXISTS `fileproblem2`;
CREATE TABLE `fileproblem2` (
  `projectunit` varchar(20) DEFAULT NULL COMMENT '项目单位',
  `getId` varchar(155) DEFAULT NULL COMMENT '领取批次号',
  `gettime` datetime DEFAULT NULL COMMENT '领取时间',
  `dangtype` varchar(20) DEFAULT NULL COMMENT '归档类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(200) DEFAULT NULL COMMENT '年限',
  `ID` int(255) NOT NULL AUTO_INCREMENT COMMENT '档号',
  `problem` varchar(150) DEFAULT NULL COMMENT '问题描述',
  `solve` varchar(150) DEFAULT NULL COMMENT '解决方案',
  `projectunit2` varchar(20) DEFAULT NULL COMMENT '项目单位2',
  `swapdate` datetime DEFAULT NULL COMMENT '加工单位',
  `swapdate2` datetime DEFAULT NULL COMMENT '日期',
  `processunit` varchar(20) DEFAULT NULL,
  `flag` varchar(20) DEFAULT NULL,
  `status1` varchar(20) DEFAULT NULL,
  `page` int(20) DEFAULT NULL,
  `paged` int(20) DEFAULT NULL,
  `bh` varchar(150) DEFAULT NULL,
  `pId` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='档案问题确认单';

-- ----------------------------
-- Records of fileproblem2
-- ----------------------------

-- ----------------------------
-- Table structure for `fileproblem3`
-- ----------------------------
DROP TABLE IF EXISTS `fileproblem3`;
CREATE TABLE `fileproblem3` (
  `projectunit` varchar(20) DEFAULT NULL COMMENT '项目单位',
  `getId` varchar(200) DEFAULT NULL COMMENT '领取批次号',
  `gettime` datetime DEFAULT NULL COMMENT '领取时间',
  `dangtype` varchar(20) DEFAULT NULL COMMENT '归档类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(200) DEFAULT NULL COMMENT '年限',
  `ID` int(255) NOT NULL AUTO_INCREMENT COMMENT '档号',
  `problem` varchar(150) DEFAULT NULL COMMENT '问题描述',
  `solve` varchar(150) DEFAULT NULL COMMENT '解决方案',
  `projectunit2` varchar(20) DEFAULT NULL COMMENT '项目单位2',
  `swapdate` datetime DEFAULT NULL COMMENT '加工单位',
  `swapdate2` datetime DEFAULT NULL COMMENT '日期',
  `processunit` varchar(20) DEFAULT NULL,
  `flag` varchar(20) DEFAULT NULL,
  `status1` varchar(20) DEFAULT NULL,
  `page` int(20) DEFAULT NULL,
  `paged` int(20) DEFAULT NULL,
  `bh` varchar(150) DEFAULT NULL,
  `pId` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='档案问题确认单';

-- ----------------------------
-- Records of fileproblem3
-- ----------------------------

-- ----------------------------
-- Table structure for `fileproblem4`
-- ----------------------------
DROP TABLE IF EXISTS `fileproblem4`;
CREATE TABLE `fileproblem4` (
  `projectunit` varchar(20) DEFAULT NULL COMMENT '项目单位',
  `getId` varchar(200) DEFAULT NULL COMMENT '领取批次号',
  `gettime` datetime DEFAULT NULL COMMENT '领取时间',
  `dangtype` varchar(20) DEFAULT NULL COMMENT '归档类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(200) DEFAULT NULL COMMENT '年限',
  `ID` int(255) NOT NULL AUTO_INCREMENT COMMENT '档号',
  `problem` varchar(150) DEFAULT NULL COMMENT '问题描述',
  `solve` varchar(150) DEFAULT NULL COMMENT '解决方案',
  `projectunit2` varchar(20) DEFAULT NULL COMMENT '项目单位2',
  `swapdate` datetime DEFAULT NULL COMMENT '加工单位',
  `swapdate2` datetime DEFAULT NULL COMMENT '日期',
  `processunit` varchar(20) DEFAULT NULL,
  `flag` varchar(20) DEFAULT NULL,
  `status1` varchar(20) DEFAULT NULL,
  `page` int(20) DEFAULT NULL,
  `paged` int(20) DEFAULT NULL,
  `bh` varchar(150) DEFAULT NULL,
  `pId` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='档案问题确认单';

-- ----------------------------
-- Records of fileproblem4
-- ----------------------------
INSERT INTO `fileproblem4` VALUES ('54646844', '002-003-001', '2018-11-23 09:59:02', '86744', '案卷', '464', '1', '', '', '54646844', '2018-11-23 09:59:02', '2018-11-23 09:59:02', '12', null, null, null, null, '1', null);
INSERT INTO `fileproblem4` VALUES ('54646844', '002-003-001', '2018-11-23 09:59:02', '86744', '案卷', '464', '2', '', '', '54646844', '2018-11-23 09:59:02', '2018-11-23 09:59:02', '12', null, null, null, null, '2', null);

-- ----------------------------
-- Table structure for `fileproblem5`
-- ----------------------------
DROP TABLE IF EXISTS `fileproblem5`;
CREATE TABLE `fileproblem5` (
  `projectunit` varchar(20) DEFAULT NULL COMMENT '项目单位',
  `getId` varchar(200) DEFAULT NULL COMMENT '领取批次号',
  `gettime` datetime DEFAULT NULL COMMENT '领取时间',
  `dangtype` varchar(20) DEFAULT NULL COMMENT '归档类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(200) DEFAULT NULL COMMENT '年限',
  `ID` int(255) NOT NULL AUTO_INCREMENT COMMENT '档号',
  `problem` varchar(150) DEFAULT NULL COMMENT '问题描述',
  `solve` varchar(150) DEFAULT NULL COMMENT '解决方案',
  `projectunit2` varchar(20) DEFAULT NULL COMMENT '项目单位2',
  `swapdate` datetime DEFAULT NULL COMMENT '加工单位',
  `swapdate2` datetime DEFAULT NULL COMMENT '日期',
  `processunit` varchar(20) DEFAULT NULL,
  `flag` varchar(20) DEFAULT NULL,
  `status1` varchar(20) DEFAULT NULL,
  `page` int(20) DEFAULT NULL,
  `paged` int(20) DEFAULT NULL,
  `bh` varchar(150) DEFAULT NULL,
  `pId` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='档案问题确认单';

-- ----------------------------
-- Records of fileproblem5
-- ----------------------------

-- ----------------------------
-- Table structure for `fileproblem6`
-- ----------------------------
DROP TABLE IF EXISTS `fileproblem6`;
CREATE TABLE `fileproblem6` (
  `projectunit` varchar(20) DEFAULT NULL COMMENT '项目单位',
  `getId` varchar(200) DEFAULT NULL COMMENT '领取批次号',
  `gettime` datetime DEFAULT NULL COMMENT '领取时间',
  `dangtype` varchar(20) DEFAULT NULL COMMENT '归档类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(200) DEFAULT NULL COMMENT '年限',
  `ID` int(255) NOT NULL AUTO_INCREMENT COMMENT '档号',
  `problem` varchar(150) DEFAULT NULL COMMENT '问题描述',
  `solve` varchar(150) DEFAULT NULL COMMENT '解决方案',
  `projectunit2` varchar(20) DEFAULT NULL COMMENT '项目单位2',
  `swapdate` datetime DEFAULT NULL COMMENT '加工单位',
  `swapdate2` datetime DEFAULT NULL COMMENT '日期',
  `processunit` varchar(20) DEFAULT NULL,
  `flag` varchar(20) DEFAULT NULL,
  `status1` varchar(20) DEFAULT NULL,
  `page` int(20) DEFAULT NULL,
  `paged` int(20) DEFAULT NULL,
  `bh` varchar(150) DEFAULT NULL,
  `pId` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='档案问题确认单';

-- ----------------------------
-- Records of fileproblem6
-- ----------------------------

-- ----------------------------
-- Table structure for `fileproblem7`
-- ----------------------------
DROP TABLE IF EXISTS `fileproblem7`;
CREATE TABLE `fileproblem7` (
  `projectunit` varchar(20) DEFAULT NULL COMMENT '项目单位',
  `getId` varchar(255) DEFAULT NULL COMMENT '领取批次号',
  `gettime` datetime DEFAULT NULL COMMENT '领取时间',
  `dangtype` varchar(20) DEFAULT NULL COMMENT '归档类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(200) DEFAULT NULL COMMENT '年限',
  `ID` int(255) NOT NULL AUTO_INCREMENT COMMENT '档号',
  `problem` varchar(150) DEFAULT NULL COMMENT '问题描述',
  `solve` varchar(150) DEFAULT NULL COMMENT '解决方案',
  `projectunit2` varchar(20) DEFAULT NULL COMMENT '项目单位2',
  `swapdate` datetime DEFAULT NULL COMMENT '加工单位',
  `swapdate2` datetime DEFAULT NULL COMMENT '日期',
  `processunit` varchar(20) DEFAULT NULL,
  `flag` varchar(20) DEFAULT NULL,
  `status1` varchar(20) DEFAULT NULL,
  `page` int(20) DEFAULT NULL,
  `paged` int(20) DEFAULT NULL,
  `bh` varchar(150) DEFAULT NULL,
  `pId` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='档案问题确认单';

-- ----------------------------
-- Records of fileproblem7
-- ----------------------------

-- ----------------------------
-- Table structure for `fileproblem8`
-- ----------------------------
DROP TABLE IF EXISTS `fileproblem8`;
CREATE TABLE `fileproblem8` (
  `projectunit` varchar(20) DEFAULT NULL COMMENT '项目单位',
  `getId` varchar(255) DEFAULT NULL COMMENT '领取批次号',
  `gettime` datetime DEFAULT NULL COMMENT '领取时间',
  `dangtype` varchar(20) DEFAULT NULL COMMENT '归档类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(200) DEFAULT NULL COMMENT '年限',
  `ID` int(255) NOT NULL AUTO_INCREMENT COMMENT '档号',
  `problem` varchar(150) DEFAULT NULL COMMENT '问题描述',
  `solve` varchar(150) DEFAULT NULL COMMENT '解决方案',
  `projectunit2` varchar(20) DEFAULT NULL COMMENT '项目单位2',
  `swapdate` datetime DEFAULT NULL COMMENT '加工单位',
  `swapdate2` datetime DEFAULT NULL COMMENT '日期',
  `processunit` varchar(20) DEFAULT NULL,
  `flag` varchar(20) DEFAULT NULL,
  `status1` varchar(20) DEFAULT NULL,
  `page` int(20) DEFAULT NULL,
  `paged` int(20) DEFAULT NULL,
  `bh` varchar(150) DEFAULT NULL,
  `pId` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='档案问题确认单';

-- ----------------------------
-- Records of fileproblem8
-- ----------------------------

-- ----------------------------
-- Table structure for `fileproblem9`
-- ----------------------------
DROP TABLE IF EXISTS `fileproblem9`;
CREATE TABLE `fileproblem9` (
  `projectunit` varchar(20) DEFAULT NULL COMMENT '项目单位',
  `getId` varchar(255) DEFAULT NULL COMMENT '领取批次号',
  `gettime` datetime DEFAULT NULL COMMENT '领取时间',
  `dangtype` varchar(20) DEFAULT NULL COMMENT '归档类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(200) DEFAULT NULL COMMENT '年限',
  `ID` int(255) NOT NULL AUTO_INCREMENT COMMENT '档号',
  `problem` varchar(150) DEFAULT NULL COMMENT '问题描述',
  `solve` varchar(150) DEFAULT NULL COMMENT '解决方案',
  `projectunit2` varchar(20) DEFAULT NULL COMMENT '项目单位2',
  `swapdate` datetime DEFAULT NULL COMMENT '加工单位',
  `swapdate2` datetime DEFAULT NULL COMMENT '日期',
  `processunit` varchar(20) DEFAULT NULL,
  `flag` varchar(20) DEFAULT NULL,
  `status1` varchar(20) DEFAULT NULL,
  `page` int(20) DEFAULT NULL,
  `paged` int(20) DEFAULT NULL,
  `bh` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='档案问题确认单';

-- ----------------------------
-- Records of fileproblem9
-- ----------------------------

-- ----------------------------
-- Table structure for `fileprocess`
-- ----------------------------
DROP TABLE IF EXISTS `fileprocess`;
CREATE TABLE `fileprocess` (
  `projectunit` varchar(20) DEFAULT NULL COMMENT '项目单位',
  `getId` varchar(200) NOT NULL COMMENT '领取批次号',
  `lzId` varchar(200) NOT NULL COMMENT '流转单号',
  `filetype` varchar(20) DEFAULT NULL COMMENT '档案类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(20) DEFAULT NULL COMMENT '年限',
  `bh` varchar(200) NOT NULL COMMENT '档号',
  `process` varchar(20) DEFAULT NULL COMMENT '加工流程',
  `processdate` datetime DEFAULT NULL COMMENT '加工日期',
  `responesible` varchar(10) DEFAULT NULL COMMENT '责任人',
  `page` int(10) DEFAULT NULL COMMENT '页数',
  `flag` int(10) DEFAULT NULL,
  `status1` int(10) DEFAULT NULL,
  PRIMARY KEY (`bh`,`getId`,`lzId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='加工流转单';

-- ----------------------------
-- Records of fileprocess
-- ----------------------------
INSERT INTO `fileprocess` VALUES ('国土局', '12-001', '12-001-001', '文档', '项目', '2', '1', '编码', '2018-12-20 21:56:20', '123', '24', null, null);
INSERT INTO `fileprocess` VALUES ('4123', '1342-001', '1342-001-001', '512', '文件', '234', '1', '编码', '2018-12-25 16:45:59', '123', '33', null, null);
INSERT INTO `fileprocess` VALUES ('4123', '1342-002', '1342-002-001', '512', '文件', '234', '1', '编码', '2018-12-25 22:19:18', '123', '11', null, null);
INSERT INTO `fileprocess` VALUES ('123', '45634-001', '45634-001-001', '123', '项目', '123', '1', '编码', '2018-12-26 11:35:16', '123', '11', null, null);
INSERT INTO `fileprocess` VALUES ('4123', '1342-005', '1342-005-001', '512', '文件', '234', '11', '编码', '2018-12-26 11:19:52', '123', '22', null, null);
INSERT INTO `fileprocess` VALUES ('4123', '1342-005', '1342-005-001', '512', '文件', '234', '12', '编码', '2018-12-26 11:19:52', '123', '22', null, null);
INSERT INTO `fileprocess` VALUES ('4123', '1342-006', '1342-006-001', '512', '文件', '234', '13', '编码', '2018-12-26 11:22:30', '123', '22', null, null);
INSERT INTO `fileprocess` VALUES ('4123', '1342-006', '1342-006-001', '512', '文件', '234', '14', '编码', '2018-12-26 11:22:30', '123', '22', null, null);
INSERT INTO `fileprocess` VALUES ('国土局', '12-001', '12-001-001', '文档', '项目', '2', '2', '编码', '2018-12-20 21:56:20', '123', '24', null, null);
INSERT INTO `fileprocess` VALUES ('4123', '1342-001', '1342-001-001', '512', '文件', '234', '2', '编码', '2018-12-25 16:45:59', '123', '33', null, null);
INSERT INTO `fileprocess` VALUES ('国土局', '12-002', '12-002-001', '文档', '项目', '2', '3', '编码', '2018-12-25 15:15:18', '123', '24', null, null);
INSERT INTO `fileprocess` VALUES ('4123', '1342-001', '1342-001-001', '512', '文件', '234', '3', '编码', '2018-12-25 16:45:59', '123', '33', null, null);
INSERT INTO `fileprocess` VALUES ('国土局', '12-002', '12-002-001', '文档', '项目', '2', '4', '编码', '2018-12-25 15:15:18', '123', '24', null, null);
INSERT INTO `fileprocess` VALUES ('4123', '1342-003', '1342-003-001', '512', '文件', '234', '5', '编码', '2018-12-26 11:02:37', '123', '22', null, null);
INSERT INTO `fileprocess` VALUES ('4123', '1342-003', '1342-003-001', '512', '文件', '234', '6', '编码', '2018-12-26 11:02:37', '123', '22', null, null);
INSERT INTO `fileprocess` VALUES ('4123', '1342-004', '1342-004-001', '512', '文件', '234', '7', '编码', '2018-12-26 11:09:05', '123', '22', null, null);
INSERT INTO `fileprocess` VALUES ('4123', '1342-004', '1342-004-001', '512', '文件', '234', '8', '编码', '2018-12-26 11:09:05', '123', '22', null, null);

-- ----------------------------
-- Table structure for `fileprocess10`
-- ----------------------------
DROP TABLE IF EXISTS `fileprocess10`;
CREATE TABLE `fileprocess10` (
  `projectunit` varchar(20) NOT NULL COMMENT '项目单位',
  `getId` int(20) DEFAULT NULL COMMENT '领取批次号',
  `lzId` int(20) DEFAULT NULL COMMENT '流转单号',
  `filetype` varchar(20) DEFAULT NULL COMMENT '档案类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(20) DEFAULT NULL COMMENT '年限',
  `dangId` int(20) DEFAULT NULL COMMENT '档号',
  `process` varchar(20) DEFAULT NULL COMMENT '加工流程',
  `processdate` datetime DEFAULT NULL COMMENT '加工日期',
  `responesible` varchar(10) DEFAULT NULL COMMENT '责任人',
  `page` int(10) DEFAULT NULL COMMENT '页数',
  PRIMARY KEY (`projectunit`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='加工流转单';

-- ----------------------------
-- Records of fileprocess10
-- ----------------------------

-- ----------------------------
-- Table structure for `fileprocess11`
-- ----------------------------
DROP TABLE IF EXISTS `fileprocess11`;
CREATE TABLE `fileprocess11` (
  `projectunit` varchar(20) NOT NULL COMMENT '项目单位',
  `getId` int(20) DEFAULT NULL COMMENT '领取批次号',
  `lzId` int(20) DEFAULT NULL COMMENT '流转单号',
  `filetype` varchar(20) DEFAULT NULL COMMENT '档案类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(20) DEFAULT NULL COMMENT '年限',
  `dangId` int(20) DEFAULT NULL COMMENT '档号',
  `process` varchar(20) DEFAULT NULL COMMENT '加工流程',
  `processdate` datetime DEFAULT NULL COMMENT '加工日期',
  `responesible` varchar(10) DEFAULT NULL COMMENT '责任人',
  `page` int(10) DEFAULT NULL COMMENT '页数',
  PRIMARY KEY (`projectunit`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='加工流转单';

-- ----------------------------
-- Records of fileprocess11
-- ----------------------------

-- ----------------------------
-- Table structure for `fileprocess2`
-- ----------------------------
DROP TABLE IF EXISTS `fileprocess2`;
CREATE TABLE `fileprocess2` (
  `projectunit` varchar(20) NOT NULL COMMENT '项目单位',
  `getId` int(20) DEFAULT NULL COMMENT '领取批次号',
  `lzId` int(20) DEFAULT NULL COMMENT '流转单号',
  `filetype` varchar(20) DEFAULT NULL COMMENT '档案类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(20) DEFAULT NULL COMMENT '年限',
  `dangId` int(20) DEFAULT NULL COMMENT '档号',
  `process` varchar(20) DEFAULT NULL COMMENT '加工流程',
  `processdate` datetime DEFAULT NULL COMMENT '加工日期',
  `responesible` varchar(10) DEFAULT NULL COMMENT '责任人',
  `page` int(10) DEFAULT NULL COMMENT '页数',
  PRIMARY KEY (`projectunit`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='加工流转单';

-- ----------------------------
-- Records of fileprocess2
-- ----------------------------

-- ----------------------------
-- Table structure for `fileprocess3`
-- ----------------------------
DROP TABLE IF EXISTS `fileprocess3`;
CREATE TABLE `fileprocess3` (
  `projectunit` varchar(20) NOT NULL COMMENT '项目单位',
  `getId` int(20) DEFAULT NULL COMMENT '领取批次号',
  `lzId` int(20) DEFAULT NULL COMMENT '流转单号',
  `filetype` varchar(20) DEFAULT NULL COMMENT '档案类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(20) DEFAULT NULL COMMENT '年限',
  `dangId` int(20) DEFAULT NULL COMMENT '档号',
  `process` varchar(20) DEFAULT NULL COMMENT '加工流程',
  `processdate` datetime DEFAULT NULL COMMENT '加工日期',
  `responesible` varchar(10) DEFAULT NULL COMMENT '责任人',
  `page` int(10) DEFAULT NULL COMMENT '页数',
  PRIMARY KEY (`projectunit`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='加工流转单';

-- ----------------------------
-- Records of fileprocess3
-- ----------------------------

-- ----------------------------
-- Table structure for `fileprocess4`
-- ----------------------------
DROP TABLE IF EXISTS `fileprocess4`;
CREATE TABLE `fileprocess4` (
  `projectunit` varchar(20) NOT NULL COMMENT '项目单位',
  `getId` int(20) DEFAULT NULL COMMENT '领取批次号',
  `lzId` int(20) DEFAULT NULL COMMENT '流转单号',
  `filetype` varchar(20) DEFAULT NULL COMMENT '档案类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(20) DEFAULT NULL COMMENT '年限',
  `dangId` int(20) DEFAULT NULL COMMENT '档号',
  `process` varchar(20) DEFAULT NULL COMMENT '加工流程',
  `processdate` datetime DEFAULT NULL COMMENT '加工日期',
  `responesible` varchar(10) DEFAULT NULL COMMENT '责任人',
  `page` int(10) DEFAULT NULL COMMENT '页数',
  PRIMARY KEY (`projectunit`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='加工流转单';

-- ----------------------------
-- Records of fileprocess4
-- ----------------------------

-- ----------------------------
-- Table structure for `fileprocess5`
-- ----------------------------
DROP TABLE IF EXISTS `fileprocess5`;
CREATE TABLE `fileprocess5` (
  `projectunit` varchar(20) NOT NULL COMMENT '项目单位',
  `getId` int(20) DEFAULT NULL COMMENT '领取批次号',
  `lzId` int(20) DEFAULT NULL COMMENT '流转单号',
  `filetype` varchar(20) DEFAULT NULL COMMENT '档案类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(20) DEFAULT NULL COMMENT '年限',
  `dangId` int(20) DEFAULT NULL COMMENT '档号',
  `process` varchar(20) DEFAULT NULL COMMENT '加工流程',
  `processdate` datetime DEFAULT NULL COMMENT '加工日期',
  `responesible` varchar(10) DEFAULT NULL COMMENT '责任人',
  `page` int(10) DEFAULT NULL COMMENT '页数',
  PRIMARY KEY (`projectunit`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='加工流转单';

-- ----------------------------
-- Records of fileprocess5
-- ----------------------------

-- ----------------------------
-- Table structure for `fileprocess6`
-- ----------------------------
DROP TABLE IF EXISTS `fileprocess6`;
CREATE TABLE `fileprocess6` (
  `projectunit` varchar(20) NOT NULL COMMENT '项目单位',
  `getId` int(20) DEFAULT NULL COMMENT '领取批次号',
  `lzId` int(20) DEFAULT NULL COMMENT '流转单号',
  `filetype` varchar(20) DEFAULT NULL COMMENT '档案类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(20) DEFAULT NULL COMMENT '年限',
  `dangId` int(20) DEFAULT NULL COMMENT '档号',
  `process` varchar(20) DEFAULT NULL COMMENT '加工流程',
  `processdate` datetime DEFAULT NULL COMMENT '加工日期',
  `responesible` varchar(10) DEFAULT NULL COMMENT '责任人',
  `page` int(10) DEFAULT NULL COMMENT '页数',
  PRIMARY KEY (`projectunit`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='加工流转单';

-- ----------------------------
-- Records of fileprocess6
-- ----------------------------

-- ----------------------------
-- Table structure for `fileprocess7`
-- ----------------------------
DROP TABLE IF EXISTS `fileprocess7`;
CREATE TABLE `fileprocess7` (
  `projectunit` varchar(20) NOT NULL COMMENT '项目单位',
  `getId` int(20) DEFAULT NULL COMMENT '领取批次号',
  `lzId` int(20) DEFAULT NULL COMMENT '流转单号',
  `filetype` varchar(20) DEFAULT NULL COMMENT '档案类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(20) DEFAULT NULL COMMENT '年限',
  `dangId` int(20) DEFAULT NULL COMMENT '档号',
  `process` varchar(20) DEFAULT NULL COMMENT '加工流程',
  `processdate` datetime DEFAULT NULL COMMENT '加工日期',
  `responesible` varchar(10) DEFAULT NULL COMMENT '责任人',
  `page` int(10) DEFAULT NULL COMMENT '页数',
  PRIMARY KEY (`projectunit`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='加工流转单';

-- ----------------------------
-- Records of fileprocess7
-- ----------------------------

-- ----------------------------
-- Table structure for `fileprocess8`
-- ----------------------------
DROP TABLE IF EXISTS `fileprocess8`;
CREATE TABLE `fileprocess8` (
  `projectunit` varchar(20) NOT NULL COMMENT '项目单位',
  `getId` int(20) DEFAULT NULL COMMENT '领取批次号',
  `lzId` int(20) DEFAULT NULL COMMENT '流转单号',
  `filetype` varchar(20) DEFAULT NULL COMMENT '档案类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(20) DEFAULT NULL COMMENT '年限',
  `dangId` int(20) DEFAULT NULL COMMENT '档号',
  `process` varchar(20) DEFAULT NULL COMMENT '加工流程',
  `processdate` datetime DEFAULT NULL COMMENT '加工日期',
  `responesible` varchar(10) DEFAULT NULL COMMENT '责任人',
  `page` int(10) DEFAULT NULL COMMENT '页数',
  PRIMARY KEY (`projectunit`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='加工流转单';

-- ----------------------------
-- Records of fileprocess8
-- ----------------------------

-- ----------------------------
-- Table structure for `fileprocess9`
-- ----------------------------
DROP TABLE IF EXISTS `fileprocess9`;
CREATE TABLE `fileprocess9` (
  `projectunit` varchar(20) NOT NULL COMMENT '项目单位',
  `getId` int(20) DEFAULT NULL COMMENT '领取批次号',
  `lzId` int(20) DEFAULT NULL COMMENT '流转单号',
  `filetype` varchar(20) DEFAULT NULL COMMENT '档案类型',
  `gdmethod` varchar(20) DEFAULT NULL COMMENT '归档方式',
  `year` varchar(20) DEFAULT NULL COMMENT '年限',
  `dangId` int(20) DEFAULT NULL COMMENT '档号',
  `process` varchar(20) DEFAULT NULL COMMENT '加工流程',
  `processdate` datetime DEFAULT NULL COMMENT '加工日期',
  `responesible` varchar(10) DEFAULT NULL COMMENT '责任人',
  `page` int(10) DEFAULT NULL COMMENT '页数',
  PRIMARY KEY (`projectunit`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='加工流转单';

-- ----------------------------
-- Records of fileprocess9
-- ----------------------------

-- ----------------------------
-- Table structure for `fileprogress`
-- ----------------------------
DROP TABLE IF EXISTS `fileprogress`;
CREATE TABLE `fileprogress` (
  `getId` int(10) NOT NULL COMMENT '领取批次号',
  `filetype` varchar(15) DEFAULT NULL COMMENT '档案类型',
  `years` int(10) DEFAULT NULL COMMENT '年度',
  `lsId` int(15) DEFAULT NULL COMMENT '流水单号',
  `page` int(15) DEFAULT NULL COMMENT '卷数',
  `pages` int(15) DEFAULT NULL COMMENT '总页数',
  `code` int(10) DEFAULT NULL COMMENT '编码',
  `split` int(10) DEFAULT NULL COMMENT '拆分',
  `zhulu` int(10) DEFAULT NULL COMMENT '著录',
  `saomiao` int(10) DEFAULT NULL COMMENT '扫描',
  `xiutu` int(10) DEFAULT NULL COMMENT '修图',
  `zhijian` int(10) DEFAULT NULL COMMENT '质检',
  `guajie` int(10) DEFAULT NULL COMMENT '挂接PDF',
  `huanyuan` int(10) DEFAULT NULL COMMENT '还原',
  `guihuan` int(10) DEFAULT NULL COMMENT '归还',
  PRIMARY KEY (`getId`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='批次进度表';

-- ----------------------------
-- Records of fileprogress
-- ----------------------------

-- ----------------------------
-- Table structure for `jd`
-- ----------------------------
DROP TABLE IF EXISTS `jd`;
CREATE TABLE `jd` (
  `pId` varchar(255) DEFAULT NULL,
  `LID` int(255) DEFAULT NULL,
  `Lname` varchar(255) DEFAULT NULL,
  `up` varchar(255) DEFAULT NULL,
  `down` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of jd
-- ----------------------------
INSERT INTO `jd` VALUES ('1342', '1', '领取', '', '');
INSERT INTO `jd` VALUES ('1342', '2', '打码', '1', '');
INSERT INTO `jd` VALUES ('1342', '3', '拆分', '2', '');
INSERT INTO `jd` VALUES ('1342', '4', '著录', '3', '');
INSERT INTO `jd` VALUES ('1342', '5', '再次著录', '4', '');
INSERT INTO `jd` VALUES ('1342', '6', '扫描', '5', '');
INSERT INTO `jd` VALUES ('1342', '7', '图处', '6', '');
INSERT INTO `jd` VALUES ('1342', '8', '质检', '7', '');
INSERT INTO `jd` VALUES ('1342', '9', '挂接', '8', '');
INSERT INTO `jd` VALUES ('1342', '10', '还原', '9', '');
INSERT INTO `jd` VALUES ('1342', '11', '归还', '10', '');
INSERT INTO `jd` VALUES ('45634', '1', '领取', '', '');
INSERT INTO `jd` VALUES ('45634', '2', '打码', '1', '');
INSERT INTO `jd` VALUES ('45634', '3', '拆分', '2', '');
INSERT INTO `jd` VALUES ('45634', '4', '著录', '3', '');
INSERT INTO `jd` VALUES ('45634', '5', '再次著录', '4', '');
INSERT INTO `jd` VALUES ('45634', '6', '扫描', '5', '');
INSERT INTO `jd` VALUES ('45634', '7', '图处', '6', '');
INSERT INTO `jd` VALUES ('45634', '8', '质检', '7', '');
INSERT INTO `jd` VALUES ('45634', '9', '挂接', '8', '');
INSERT INTO `jd` VALUES ('45634', '10', '还原', '9', '');
INSERT INTO `jd` VALUES ('45634', '11', '归还', '10', '');

-- ----------------------------
-- Table structure for `lzd`
-- ----------------------------
DROP TABLE IF EXISTS `lzd`;
CREATE TABLE `lzd` (
  `LID` int(255) NOT NULL,
  `Lname` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`LID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of lzd
-- ----------------------------
INSERT INTO `lzd` VALUES ('1', '领取');
INSERT INTO `lzd` VALUES ('2', '打码');
INSERT INTO `lzd` VALUES ('3', '拆分');
INSERT INTO `lzd` VALUES ('4', '著录');
INSERT INTO `lzd` VALUES ('5', '再次著录');
INSERT INTO `lzd` VALUES ('6', '扫描');
INSERT INTO `lzd` VALUES ('7', '图处');
INSERT INTO `lzd` VALUES ('8', '质检');
INSERT INTO `lzd` VALUES ('9', '挂接');
INSERT INTO `lzd` VALUES ('10', '还原');
INSERT INTO `lzd` VALUES ('11', '归还');

-- ----------------------------
-- Table structure for `nprocessing`
-- ----------------------------
DROP TABLE IF EXISTS `nprocessing`;
CREATE TABLE `nprocessing` (
  `pId` varchar(255) DEFAULT NULL,
  `LID` int(255) DEFAULT NULL,
  `Lname` varchar(255) DEFAULT NULL,
  `status` varchar(255) DEFAULT '0',
  `getId` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of nprocessing
-- ----------------------------
INSERT INTO `nprocessing` VALUES ('1342', '1', '领取', '0', null);
INSERT INTO `nprocessing` VALUES ('1342', '2', '打码', '0', null);
INSERT INTO `nprocessing` VALUES ('1342', '3', '拆分', '0', null);
INSERT INTO `nprocessing` VALUES ('1342', '4', '著录', '0', null);
INSERT INTO `nprocessing` VALUES ('1342', '5', '再次著录', '0', null);
INSERT INTO `nprocessing` VALUES ('1342', '6', '扫描', '0', null);
INSERT INTO `nprocessing` VALUES ('1342', '7', '图处', '0', null);
INSERT INTO `nprocessing` VALUES ('1342', '8', '质检', '0', null);
INSERT INTO `nprocessing` VALUES ('1342', '9', '挂接', '0', null);
INSERT INTO `nprocessing` VALUES ('1342', '10', '还原', '0', null);
INSERT INTO `nprocessing` VALUES ('1342', '11', '归还', '0', null);
INSERT INTO `nprocessing` VALUES ('45634', '1', '领取', '0', null);
INSERT INTO `nprocessing` VALUES ('45634', '2', '打码', '0', null);
INSERT INTO `nprocessing` VALUES ('45634', '3', '拆分', '0', null);
INSERT INTO `nprocessing` VALUES ('45634', '4', '著录', '0', null);
INSERT INTO `nprocessing` VALUES ('45634', '5', '再次著录', '0', null);
INSERT INTO `nprocessing` VALUES ('45634', '6', '扫描', '0', null);
INSERT INTO `nprocessing` VALUES ('45634', '7', '图处', '0', null);
INSERT INTO `nprocessing` VALUES ('45634', '8', '质检', '0', null);
INSERT INTO `nprocessing` VALUES ('45634', '9', '挂接', '0', null);
INSERT INTO `nprocessing` VALUES ('45634', '10', '还原', '0', null);
INSERT INTO `nprocessing` VALUES ('45634', '11', '归还', '0', null);

-- ----------------------------
-- Table structure for `nprocessing2`
-- ----------------------------
DROP TABLE IF EXISTS `nprocessing2`;
CREATE TABLE `nprocessing2` (
  `pId` varchar(255) DEFAULT NULL,
  `bh` varchar(255) DEFAULT NULL,
  `LID` varchar(255) DEFAULT NULL,
  `Lname` varchar(255) DEFAULT NULL,
  `status` varchar(255) DEFAULT '0',
  `getId` varchar(255) DEFAULT NULL,
  `problem` varchar(255) DEFAULT NULL,
  `page` varchar(255) DEFAULT NULL,
  `zrr` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of nprocessing2
-- ----------------------------
INSERT INTO `nprocessing2` VALUES ('1342', '1', '1', '领取', '1', '1342-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '1', '2', '打码', '1', '1342-001', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '1', '3', '拆分', '1', '1342-001', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '1', '4', '著录', '1', '1342-001', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '1', '5', '再次著录', '0', '1342-001', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '1', '6', '扫描', '0', '1342-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '1', '7', '图处', '0', '1342-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '1', '8', '质检', '0', '1342-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '1', '9', '挂接', '0', '1342-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '1', '10', '还原', '0', '1342-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '1', '11', '归还', '0', '1342-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '2', '1', '领取', '1', '1342-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '2', '2', '打码', '1', '1342-001', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '2', '3', '拆分', '1', '1342-001', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '2', '4', '著录', '1', '1342-001', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '2', '5', '再次著录', '0', '1342-001', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '2', '6', '扫描', '0', '1342-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '2', '7', '图处', '0', '1342-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '2', '8', '质检', '0', '1342-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '2', '9', '挂接', '0', '1342-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '2', '10', '还原', '0', '1342-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '2', '11', '归还', '0', '1342-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '3', '1', '领取', '1', '1342-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '3', '2', '打码', '1', '1342-001', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '3', '3', '拆分', '1', '1342-001', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '3', '4', '著录', '1', '1342-001', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '3', '5', '再次著录', '0', '1342-001', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '3', '6', '扫描', '0', '1342-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '3', '7', '图处', '0', '1342-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '3', '8', '质检', '0', '1342-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '3', '9', '挂接', '0', '1342-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '3', '10', '还原', '0', '1342-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '3', '11', '归还', '0', '1342-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '1', '1', '领取', '1', '1342-002', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '1', '2', '打码', '1', '1342-002', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '1', '3', '拆分', '1', '1342-002', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '1', '4', '著录', '1', '1342-002', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '1', '5', '再次著录', '0', '1342-002', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '1', '6', '扫描', '0', '1342-002', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '1', '7', '图处', '0', '1342-002', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '1', '8', '质检', '0', '1342-002', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '1', '9', '挂接', '0', '1342-002', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '1', '10', '还原', '0', '1342-002', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '1', '11', '归还', '0', '1342-002', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '2', '1', '领取', '1', '1342-002', null, null, null);
INSERT INTO `nprocessing2` VALUES ('1342', '2', '2', '打码', '0', '1342-002', null, null, '123');
INSERT INTO `nprocessing2` VALUES ('1342', '2', '3', '拆分', '0', '1342-002', null, null, null);
INSERT INTO `nprocessing2` VALUES ('1342', '2', '4', '著录', '0', '1342-002', null, null, null);
INSERT INTO `nprocessing2` VALUES ('1342', '2', '5', '再次著录', '0', '1342-002', null, null, null);
INSERT INTO `nprocessing2` VALUES ('1342', '2', '6', '扫描', '0', '1342-002', null, null, null);
INSERT INTO `nprocessing2` VALUES ('1342', '2', '7', '图处', '0', '1342-002', null, null, null);
INSERT INTO `nprocessing2` VALUES ('1342', '2', '8', '质检', '0', '1342-002', null, null, null);
INSERT INTO `nprocessing2` VALUES ('1342', '2', '9', '挂接', '0', '1342-002', null, null, null);
INSERT INTO `nprocessing2` VALUES ('1342', '2', '10', '还原', '0', '1342-002', null, null, null);
INSERT INTO `nprocessing2` VALUES ('1342', '2', '11', '归还', '0', '1342-002', null, null, null);
INSERT INTO `nprocessing2` VALUES ('1342', '5', '1', '领取', '1', '1342-003', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '5', '2', '打码', '1', '1342-003', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '5', '3', '拆分', '1', '1342-003', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '5', '4', '著录', '1', '1342-003', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '5', '5', '再次著录', '0', '1342-003', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '5', '6', '扫描', '0', '1342-003', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '5', '7', '图处', '0', '1342-003', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '5', '8', '质检', '0', '1342-003', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '5', '9', '挂接', '0', '1342-003', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '5', '10', '还原', '0', '1342-003', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '5', '11', '归还', '0', '1342-003', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '6', '1', '领取', '1', '1342-003', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '6', '2', '打码', '1', '1342-003', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '6', '3', '拆分', '1', '1342-003', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '6', '4', '著录', '0', '1342-003', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '6', '5', '再次著录', '0', '1342-003', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '6', '6', '扫描', '0', '1342-003', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '6', '7', '图处', '0', '1342-003', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '6', '8', '质检', '0', '1342-003', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '6', '9', '挂接', '0', '1342-003', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '6', '10', '还原', '0', '1342-003', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '6', '11', '归还', '0', '1342-003', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '7', '1', '领取', '1', '1342-004', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '7', '2', '打码', '1', '1342-004', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '7', '3', '拆分', '1', '1342-004', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '7', '4', '著录', '0', '1342-004', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '7', '5', '再次著录', '0', '1342-004', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '7', '6', '扫描', '0', '1342-004', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '7', '7', '图处', '0', '1342-004', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '7', '8', '质检', '0', '1342-004', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '7', '9', '挂接', '0', '1342-004', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '7', '10', '还原', '0', '1342-004', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '7', '11', '归还', '0', '1342-004', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '8', '1', '领取', '1', '1342-004', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '8', '2', '打码', '1', '1342-004', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '8', '3', '拆分', '1', '1342-004', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '8', '4', '著录', '1', '1342-004', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '8', '5', '再次著录', '0', '1342-004', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '8', '6', '扫描', '0', '1342-004', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '8', '7', '图处', '0', '1342-004', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '8', '8', '质检', '0', '1342-004', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '8', '9', '挂接', '0', '1342-004', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '8', '10', '还原', '0', '1342-004', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '8', '11', '归还', '0', '1342-004', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '11', '1', '领取', '1', '1342-005', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '11', '2', '打码', '1', '1342-005', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '11', '3', '拆分', '1', '1342-005', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '11', '4', '著录', '1', '1342-005', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '11', '5', '再次著录', '0', '1342-005', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '11', '6', '扫描', '0', '1342-005', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '11', '7', '图处', '0', '1342-005', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '11', '8', '质检', '0', '1342-005', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '11', '9', '挂接', '0', '1342-005', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '11', '10', '还原', '0', '1342-005', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '11', '11', '归还', '0', '1342-005', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '12', '1', '领取', '1', '1342-005', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '12', '2', '打码', '1', '1342-005', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '12', '3', '拆分', '1', '1342-005', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '12', '4', '著录', '1', '1342-005', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '12', '5', '再次著录', '0', '1342-005', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '12', '6', '扫描', '0', '1342-005', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '12', '7', '图处', '0', '1342-005', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '12', '8', '质检', '0', '1342-005', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '12', '9', '挂接', '0', '1342-005', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '12', '10', '还原', '0', '1342-005', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '12', '11', '归还', '0', '1342-005', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '13', '1', '领取', '1', '1342-006', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '13', '2', '打码', '1', '1342-006', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '13', '3', '拆分', '1', '1342-006', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '13', '4', '著录', '1', '1342-006', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '13', '5', '再次著录', '0', '1342-006', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '13', '6', '扫描', '0', '1342-006', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '13', '7', '图处', '0', '1342-006', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '13', '8', '质检', '0', '1342-006', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '13', '9', '挂接', '0', '1342-006', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '13', '10', '还原', '0', '1342-006', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '13', '11', '归还', '0', '1342-006', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '14', '1', '领取', '1', '1342-006', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '14', '2', '打码', '1', '1342-006', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '14', '3', '拆分', '1', '1342-006', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '14', '4', '著录', '1', '1342-006', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('1342', '14', '5', '再次著录', '0', '1342-006', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '14', '6', '扫描', '0', '1342-006', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '14', '7', '图处', '0', '1342-006', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '14', '8', '质检', '0', '1342-006', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '14', '9', '挂接', '0', '1342-006', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '14', '10', '还原', '0', '1342-006', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('1342', '14', '11', '归还', '0', '1342-006', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('45634', '1', '1', '领取', '1', '45634-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('45634', '1', '2', '打码', '1', '45634-001', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('45634', '1', '3', '拆分', '1', '45634-001', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('45634', '1', '4', '著录', '1', '45634-001', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('45634', '1', '5', '再次著录', '0', '45634-001', '', '11', '123');
INSERT INTO `nprocessing2` VALUES ('45634', '1', '6', '扫描', '0', '45634-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('45634', '1', '7', '图处', '0', '45634-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('45634', '1', '8', '质检', '0', '45634-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('45634', '1', '9', '挂接', '0', '45634-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('45634', '1', '10', '还原', '0', '45634-001', '', '11', null);
INSERT INTO `nprocessing2` VALUES ('45634', '1', '11', '归还', '0', '45634-001', '', '11', null);

-- ----------------------------
-- Table structure for `photourl`
-- ----------------------------
DROP TABLE IF EXISTS `photourl`;
CREATE TABLE `photourl` (
  `dangId` varchar(255) DEFAULT NULL,
  `flag` int(100) DEFAULT NULL,
  `url` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of photourl
-- ----------------------------

-- ----------------------------
-- Table structure for `project1`
-- ----------------------------
DROP TABLE IF EXISTS `project1`;
CREATE TABLE `project1` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `pId` varchar(155) DEFAULT NULL,
  `projectunit` varchar(155) DEFAULT NULL,
  `filetype` varchar(155) DEFAULT NULL,
  `gdmethod` varchar(155) DEFAULT NULL,
  `year` varchar(155) DEFAULT NULL,
  `str1` varchar(155) DEFAULT NULL,
  `str2` varchar(155) DEFAULT NULL,
  `str3` varchar(155) DEFAULT NULL,
  `str4` varchar(155) DEFAULT NULL,
  `str5` varchar(255) DEFAULT NULL,
  `url` varchar(255) DEFAULT NULL,
  `hz` varchar(255) DEFAULT NULL,
  `pgz` varchar(255) DEFAULT NULL,
  `pdfgz` varchar(255) DEFAULT NULL,
  `pdf` varchar(255) DEFAULT NULL,
  `ocr` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of project1
-- ----------------------------
INSERT INTO `project1` VALUES ('4', '12', '国土局', '文档', '项目', '2', '年度', '项目号', '案卷号', '文件号', '项目', '34355465', 'jpg', '01', '同图片命名规则', '生成单页pdf', '是');
INSERT INTO `project1` VALUES ('5', '1342', '4123', '512', '文件', '234', '项目号', '项目号', '文件号', '', '文件', '123', 'jpg', '01', '同图片命名规则', '生成单页pdf', '否');
INSERT INTO `project1` VALUES ('6', '45634', '123', '123', '项目', '123', '年度', '项目号', '文件号', '', '项目', '123', 'tiff', '001', '同图片命名规则', '生成单页pdf', '是');

-- ----------------------------
-- Table structure for `resource`
-- ----------------------------
DROP TABLE IF EXISTS `resource`;
CREATE TABLE `resource` (
  `resourceId` int(20) NOT NULL,
  `menuId` varchar(20) CHARACTER SET utf8 DEFAULT NULL,
  `menuText` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  `menuForm` varchar(20) CHARACTER SET utf8 DEFAULT NULL,
  `menuParent` int(20) DEFAULT NULL,
  `loadForm` varchar(100) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`resourceId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of resource
-- ----------------------------
INSERT INTO `resource` VALUES ('2', null, '【用户管理】', '主面', '0', 'Form员工信息管理');
INSERT INTO `resource` VALUES ('4', null, '【项目管理】', null, '0', null);
INSERT INTO `resource` VALUES ('5', null, '【项目信息定义】', null, '4', 'Form项目信息定义');
INSERT INTO `resource` VALUES ('6', null, '【项目信息查询】', null, '4', 'Form项目信息查询');
INSERT INTO `resource` VALUES ('8', null, '【领取】', null, '0', 'Form档案领取');
INSERT INTO `resource` VALUES ('9', null, '【编码】', null, '0', 'Form待加工档案');
INSERT INTO `resource` VALUES ('10', null, '【拆分】', null, '0', 'Form待加工档案');
INSERT INTO `resource` VALUES ('11', null, '【著录】', null, '0', 'Form待加工档案');
INSERT INTO `resource` VALUES ('12', null, '【扫描】', null, '0', 'Form待加工档案');
INSERT INTO `resource` VALUES ('13', null, '【图处】', null, '0', 'Form待加工档案');
INSERT INTO `resource` VALUES ('14', null, '【质检】', null, '0', 'Form待加工档案');
INSERT INTO `resource` VALUES ('15', null, '【挂接】', null, '0', 'Form待加工档案');
INSERT INTO `resource` VALUES ('16', null, '【还原】', null, '0', 'Form待加工档案');
INSERT INTO `resource` VALUES ('17', null, '【归还】', null, '0', 'Form待加工档案');
INSERT INTO `resource` VALUES ('20', null, '【考勤管理】', null, '0', 'Form考勤管理');
INSERT INTO `resource` VALUES ('21', null, '【再次著录】', null, '0', 'Form待加工档案');

-- ----------------------------
-- Table structure for `roles`
-- ----------------------------
DROP TABLE IF EXISTS `roles`;
CREATE TABLE `roles` (
  `roleId` int(20) NOT NULL,
  `roleName` varchar(255) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`roleId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of roles
-- ----------------------------
INSERT INTO `roles` VALUES ('1', '超级管理员');
INSERT INTO `roles` VALUES ('2', '管理员');
INSERT INTO `roles` VALUES ('3', '领取员');
INSERT INTO `roles` VALUES ('4', '拆分员');
INSERT INTO `roles` VALUES ('5', '著录员');
INSERT INTO `roles` VALUES ('6', '打码员');
INSERT INTO `roles` VALUES ('7', '扫描员');
INSERT INTO `roles` VALUES ('8', '编目员');
INSERT INTO `roles` VALUES ('9', '图处员');
INSERT INTO `roles` VALUES ('10', '质检员');
INSERT INTO `roles` VALUES ('11', '挂接员');
INSERT INTO `roles` VALUES ('12', '还原员');
INSERT INTO `roles` VALUES ('13', '归还原');
INSERT INTO `roles` VALUES ('14', '抽检员');
INSERT INTO `roles` VALUES ('15', '项目经理');

-- ----------------------------
-- Table structure for `role_res`
-- ----------------------------
DROP TABLE IF EXISTS `role_res`;
CREATE TABLE `role_res` (
  `useId` int(20) DEFAULT NULL,
  `resourceId` int(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of role_res
-- ----------------------------
INSERT INTO `role_res` VALUES ('2', '2');
INSERT INTO `role_res` VALUES ('2', '3');
INSERT INTO `role_res` VALUES ('2', '4');
INSERT INTO `role_res` VALUES ('2', '5');
INSERT INTO `role_res` VALUES ('2', '8');
INSERT INTO `role_res` VALUES ('2', '9');
INSERT INTO `role_res` VALUES ('2', '10');
INSERT INTO `role_res` VALUES ('2', '32');
INSERT INTO `role_res` VALUES ('2', '11');
INSERT INTO `role_res` VALUES ('2', '13');
INSERT INTO `role_res` VALUES ('2', '14');
INSERT INTO `role_res` VALUES ('2', '15');
INSERT INTO `role_res` VALUES ('2', '18');
INSERT INTO `role_res` VALUES ('2', '12');
INSERT INTO `role_res` VALUES ('2', '21');
INSERT INTO `role_res` VALUES ('4', '2');
INSERT INTO `role_res` VALUES ('5', '2');
INSERT INTO `role_res` VALUES ('6', '2');
INSERT INTO `role_res` VALUES ('10', '2');
INSERT INTO `role_res` VALUES ('11', '2');
INSERT INTO `role_res` VALUES ('13', '2');
INSERT INTO `role_res` VALUES ('0', '2');
INSERT INTO `role_res` VALUES ('4', '5');
INSERT INTO `role_res` VALUES ('4', '6');
INSERT INTO `role_res` VALUES ('5', '5');
INSERT INTO `role_res` VALUES ('5', '6');
INSERT INTO `role_res` VALUES ('6', '5');
INSERT INTO `role_res` VALUES ('6', '6');
INSERT INTO `role_res` VALUES ('10', '5');
INSERT INTO `role_res` VALUES ('10', '6');
INSERT INTO `role_res` VALUES ('11', '5');
INSERT INTO `role_res` VALUES ('11', '6');
INSERT INTO `role_res` VALUES ('13', '5');
INSERT INTO `role_res` VALUES ('13', '6');
INSERT INTO `role_res` VALUES ('0', '5');
INSERT INTO `role_res` VALUES ('0', '6');
INSERT INTO `role_res` VALUES ('4', '5');
INSERT INTO `role_res` VALUES ('4', '6');
INSERT INTO `role_res` VALUES ('5', '5');
INSERT INTO `role_res` VALUES ('5', '6');
INSERT INTO `role_res` VALUES ('6', '5');
INSERT INTO `role_res` VALUES ('6', '6');
INSERT INTO `role_res` VALUES ('10', '5');
INSERT INTO `role_res` VALUES ('10', '6');
INSERT INTO `role_res` VALUES ('11', '5');
INSERT INTO `role_res` VALUES ('11', '6');
INSERT INTO `role_res` VALUES ('13', '5');
INSERT INTO `role_res` VALUES ('13', '6');
INSERT INTO `role_res` VALUES ('0', '5');
INSERT INTO `role_res` VALUES ('0', '6');
INSERT INTO `role_res` VALUES ('4', '5');
INSERT INTO `role_res` VALUES ('4', '6');
INSERT INTO `role_res` VALUES ('5', '5');
INSERT INTO `role_res` VALUES ('5', '6');
INSERT INTO `role_res` VALUES ('6', '5');
INSERT INTO `role_res` VALUES ('6', '6');
INSERT INTO `role_res` VALUES ('10', '5');
INSERT INTO `role_res` VALUES ('10', '6');
INSERT INTO `role_res` VALUES ('11', '5');
INSERT INTO `role_res` VALUES ('11', '6');
INSERT INTO `role_res` VALUES ('13', '5');
INSERT INTO `role_res` VALUES ('13', '6');
INSERT INTO `role_res` VALUES ('0', '5');
INSERT INTO `role_res` VALUES ('0', '6');
INSERT INTO `role_res` VALUES ('4', '4');
INSERT INTO `role_res` VALUES ('4', '5');
INSERT INTO `role_res` VALUES ('4', '6');
INSERT INTO `role_res` VALUES ('5', '5');
INSERT INTO `role_res` VALUES ('5', '6');
INSERT INTO `role_res` VALUES ('6', '5');
INSERT INTO `role_res` VALUES ('6', '6');
INSERT INTO `role_res` VALUES ('10', '5');
INSERT INTO `role_res` VALUES ('10', '6');
INSERT INTO `role_res` VALUES ('11', '5');
INSERT INTO `role_res` VALUES ('11', '6');
INSERT INTO `role_res` VALUES ('13', '5');
INSERT INTO `role_res` VALUES ('13', '6');
INSERT INTO `role_res` VALUES ('0', '5');
INSERT INTO `role_res` VALUES ('0', '6');
INSERT INTO `role_res` VALUES ('5', '4');
INSERT INTO `role_res` VALUES ('4', '5');
INSERT INTO `role_res` VALUES ('4', '6');
INSERT INTO `role_res` VALUES ('5', '5');
INSERT INTO `role_res` VALUES ('5', '6');
INSERT INTO `role_res` VALUES ('6', '5');
INSERT INTO `role_res` VALUES ('6', '6');
INSERT INTO `role_res` VALUES ('10', '5');
INSERT INTO `role_res` VALUES ('10', '6');
INSERT INTO `role_res` VALUES ('11', '5');
INSERT INTO `role_res` VALUES ('11', '6');
INSERT INTO `role_res` VALUES ('13', '5');
INSERT INTO `role_res` VALUES ('13', '6');
INSERT INTO `role_res` VALUES ('0', '5');
INSERT INTO `role_res` VALUES ('0', '6');
INSERT INTO `role_res` VALUES ('6', '4');
INSERT INTO `role_res` VALUES ('4', '5');
INSERT INTO `role_res` VALUES ('4', '6');
INSERT INTO `role_res` VALUES ('5', '5');
INSERT INTO `role_res` VALUES ('5', '6');
INSERT INTO `role_res` VALUES ('6', '5');
INSERT INTO `role_res` VALUES ('6', '6');
INSERT INTO `role_res` VALUES ('10', '5');
INSERT INTO `role_res` VALUES ('10', '6');
INSERT INTO `role_res` VALUES ('11', '5');
INSERT INTO `role_res` VALUES ('11', '6');
INSERT INTO `role_res` VALUES ('13', '5');
INSERT INTO `role_res` VALUES ('13', '6');
INSERT INTO `role_res` VALUES ('0', '5');
INSERT INTO `role_res` VALUES ('0', '6');
INSERT INTO `role_res` VALUES ('4', '5');
INSERT INTO `role_res` VALUES ('4', '6');
INSERT INTO `role_res` VALUES ('5', '5');
INSERT INTO `role_res` VALUES ('5', '6');
INSERT INTO `role_res` VALUES ('6', '5');
INSERT INTO `role_res` VALUES ('6', '6');
INSERT INTO `role_res` VALUES ('10', '5');
INSERT INTO `role_res` VALUES ('10', '6');
INSERT INTO `role_res` VALUES ('11', '5');
INSERT INTO `role_res` VALUES ('11', '6');
INSERT INTO `role_res` VALUES ('13', '5');
INSERT INTO `role_res` VALUES ('13', '6');
INSERT INTO `role_res` VALUES ('0', '5');
INSERT INTO `role_res` VALUES ('0', '6');
INSERT INTO `role_res` VALUES ('4', '5');
INSERT INTO `role_res` VALUES ('4', '6');
INSERT INTO `role_res` VALUES ('5', '5');
INSERT INTO `role_res` VALUES ('5', '6');
INSERT INTO `role_res` VALUES ('6', '5');
INSERT INTO `role_res` VALUES ('6', '6');
INSERT INTO `role_res` VALUES ('10', '5');
INSERT INTO `role_res` VALUES ('10', '6');
INSERT INTO `role_res` VALUES ('11', '5');
INSERT INTO `role_res` VALUES ('11', '6');
INSERT INTO `role_res` VALUES ('13', '5');
INSERT INTO `role_res` VALUES ('13', '6');
INSERT INTO `role_res` VALUES ('0', '5');
INSERT INTO `role_res` VALUES ('0', '6');
INSERT INTO `role_res` VALUES ('4', '5');
INSERT INTO `role_res` VALUES ('4', '6');
INSERT INTO `role_res` VALUES ('5', '5');
INSERT INTO `role_res` VALUES ('5', '6');
INSERT INTO `role_res` VALUES ('6', '5');
INSERT INTO `role_res` VALUES ('6', '6');
INSERT INTO `role_res` VALUES ('10', '5');
INSERT INTO `role_res` VALUES ('10', '6');
INSERT INTO `role_res` VALUES ('11', '5');
INSERT INTO `role_res` VALUES ('11', '6');
INSERT INTO `role_res` VALUES ('13', '5');
INSERT INTO `role_res` VALUES ('13', '6');
INSERT INTO `role_res` VALUES ('0', '5');
INSERT INTO `role_res` VALUES ('0', '6');
INSERT INTO `role_res` VALUES ('10', '4');
INSERT INTO `role_res` VALUES ('4', '5');
INSERT INTO `role_res` VALUES ('4', '6');
INSERT INTO `role_res` VALUES ('5', '5');
INSERT INTO `role_res` VALUES ('5', '6');
INSERT INTO `role_res` VALUES ('6', '5');
INSERT INTO `role_res` VALUES ('6', '6');
INSERT INTO `role_res` VALUES ('10', '5');
INSERT INTO `role_res` VALUES ('10', '6');
INSERT INTO `role_res` VALUES ('11', '5');
INSERT INTO `role_res` VALUES ('11', '6');
INSERT INTO `role_res` VALUES ('13', '5');
INSERT INTO `role_res` VALUES ('13', '6');
INSERT INTO `role_res` VALUES ('0', '5');
INSERT INTO `role_res` VALUES ('0', '6');
INSERT INTO `role_res` VALUES ('11', '4');
INSERT INTO `role_res` VALUES ('4', '5');
INSERT INTO `role_res` VALUES ('4', '6');
INSERT INTO `role_res` VALUES ('5', '5');
INSERT INTO `role_res` VALUES ('5', '6');
INSERT INTO `role_res` VALUES ('6', '5');
INSERT INTO `role_res` VALUES ('6', '6');
INSERT INTO `role_res` VALUES ('10', '5');
INSERT INTO `role_res` VALUES ('10', '6');
INSERT INTO `role_res` VALUES ('11', '5');
INSERT INTO `role_res` VALUES ('11', '6');
INSERT INTO `role_res` VALUES ('13', '5');
INSERT INTO `role_res` VALUES ('13', '6');
INSERT INTO `role_res` VALUES ('0', '5');
INSERT INTO `role_res` VALUES ('0', '6');
INSERT INTO `role_res` VALUES ('4', '5');
INSERT INTO `role_res` VALUES ('4', '6');
INSERT INTO `role_res` VALUES ('5', '5');
INSERT INTO `role_res` VALUES ('5', '6');
INSERT INTO `role_res` VALUES ('6', '5');
INSERT INTO `role_res` VALUES ('6', '6');
INSERT INTO `role_res` VALUES ('10', '5');
INSERT INTO `role_res` VALUES ('10', '6');
INSERT INTO `role_res` VALUES ('11', '5');
INSERT INTO `role_res` VALUES ('11', '6');
INSERT INTO `role_res` VALUES ('13', '5');
INSERT INTO `role_res` VALUES ('13', '6');
INSERT INTO `role_res` VALUES ('0', '5');
INSERT INTO `role_res` VALUES ('0', '6');
INSERT INTO `role_res` VALUES ('13', '4');
INSERT INTO `role_res` VALUES ('4', '5');
INSERT INTO `role_res` VALUES ('4', '6');
INSERT INTO `role_res` VALUES ('5', '5');
INSERT INTO `role_res` VALUES ('5', '6');
INSERT INTO `role_res` VALUES ('6', '5');
INSERT INTO `role_res` VALUES ('6', '6');
INSERT INTO `role_res` VALUES ('10', '5');
INSERT INTO `role_res` VALUES ('10', '6');
INSERT INTO `role_res` VALUES ('11', '5');
INSERT INTO `role_res` VALUES ('11', '6');
INSERT INTO `role_res` VALUES ('13', '5');
INSERT INTO `role_res` VALUES ('13', '6');
INSERT INTO `role_res` VALUES ('0', '5');
INSERT INTO `role_res` VALUES ('0', '6');
INSERT INTO `role_res` VALUES ('0', '4');
INSERT INTO `role_res` VALUES ('4', '5');
INSERT INTO `role_res` VALUES ('4', '6');
INSERT INTO `role_res` VALUES ('5', '5');
INSERT INTO `role_res` VALUES ('5', '6');
INSERT INTO `role_res` VALUES ('6', '5');
INSERT INTO `role_res` VALUES ('6', '6');
INSERT INTO `role_res` VALUES ('10', '5');
INSERT INTO `role_res` VALUES ('10', '6');
INSERT INTO `role_res` VALUES ('11', '5');
INSERT INTO `role_res` VALUES ('11', '6');
INSERT INTO `role_res` VALUES ('13', '5');
INSERT INTO `role_res` VALUES ('13', '6');
INSERT INTO `role_res` VALUES ('0', '5');
INSERT INTO `role_res` VALUES ('0', '6');
INSERT INTO `role_res` VALUES ('4', '7');
INSERT INTO `role_res` VALUES ('5', '7');
INSERT INTO `role_res` VALUES ('6', '7');
INSERT INTO `role_res` VALUES ('10', '7');
INSERT INTO `role_res` VALUES ('11', '7');
INSERT INTO `role_res` VALUES ('13', '7');
INSERT INTO `role_res` VALUES ('0', '7');
INSERT INTO `role_res` VALUES ('4', '8');
INSERT INTO `role_res` VALUES ('5', '8');
INSERT INTO `role_res` VALUES ('6', '8');
INSERT INTO `role_res` VALUES ('10', '8');
INSERT INTO `role_res` VALUES ('11', '8');
INSERT INTO `role_res` VALUES ('13', '8');
INSERT INTO `role_res` VALUES ('0', '8');
INSERT INTO `role_res` VALUES ('4', '9');
INSERT INTO `role_res` VALUES ('5', '9');
INSERT INTO `role_res` VALUES ('6', '9');
INSERT INTO `role_res` VALUES ('10', '9');
INSERT INTO `role_res` VALUES ('11', '9');
INSERT INTO `role_res` VALUES ('13', '9');
INSERT INTO `role_res` VALUES ('0', '9');
INSERT INTO `role_res` VALUES ('4', '10');
INSERT INTO `role_res` VALUES ('5', '10');
INSERT INTO `role_res` VALUES ('6', '10');
INSERT INTO `role_res` VALUES ('10', '10');
INSERT INTO `role_res` VALUES ('11', '10');
INSERT INTO `role_res` VALUES ('13', '10');
INSERT INTO `role_res` VALUES ('0', '10');
INSERT INTO `role_res` VALUES ('4', '11');
INSERT INTO `role_res` VALUES ('5', '11');
INSERT INTO `role_res` VALUES ('6', '11');
INSERT INTO `role_res` VALUES ('10', '11');
INSERT INTO `role_res` VALUES ('11', '11');
INSERT INTO `role_res` VALUES ('13', '11');
INSERT INTO `role_res` VALUES ('0', '11');
INSERT INTO `role_res` VALUES ('4', '12');
INSERT INTO `role_res` VALUES ('5', '12');
INSERT INTO `role_res` VALUES ('6', '12');
INSERT INTO `role_res` VALUES ('10', '12');
INSERT INTO `role_res` VALUES ('11', '12');
INSERT INTO `role_res` VALUES ('13', '12');
INSERT INTO `role_res` VALUES ('0', '12');
INSERT INTO `role_res` VALUES ('4', '13');
INSERT INTO `role_res` VALUES ('5', '13');
INSERT INTO `role_res` VALUES ('6', '13');
INSERT INTO `role_res` VALUES ('10', '13');
INSERT INTO `role_res` VALUES ('11', '13');
INSERT INTO `role_res` VALUES ('13', '13');
INSERT INTO `role_res` VALUES ('0', '13');
INSERT INTO `role_res` VALUES ('4', '14');
INSERT INTO `role_res` VALUES ('5', '14');
INSERT INTO `role_res` VALUES ('6', '14');
INSERT INTO `role_res` VALUES ('10', '14');
INSERT INTO `role_res` VALUES ('11', '14');
INSERT INTO `role_res` VALUES ('13', '14');
INSERT INTO `role_res` VALUES ('0', '14');
INSERT INTO `role_res` VALUES ('4', '15');
INSERT INTO `role_res` VALUES ('5', '15');
INSERT INTO `role_res` VALUES ('6', '15');
INSERT INTO `role_res` VALUES ('10', '15');
INSERT INTO `role_res` VALUES ('11', '15');
INSERT INTO `role_res` VALUES ('13', '15');
INSERT INTO `role_res` VALUES ('0', '15');
INSERT INTO `role_res` VALUES ('4', '16');
INSERT INTO `role_res` VALUES ('5', '16');
INSERT INTO `role_res` VALUES ('6', '16');
INSERT INTO `role_res` VALUES ('10', '16');
INSERT INTO `role_res` VALUES ('11', '16');
INSERT INTO `role_res` VALUES ('13', '16');
INSERT INTO `role_res` VALUES ('0', '16');
INSERT INTO `role_res` VALUES ('4', '17');
INSERT INTO `role_res` VALUES ('5', '17');
INSERT INTO `role_res` VALUES ('6', '17');
INSERT INTO `role_res` VALUES ('10', '17');
INSERT INTO `role_res` VALUES ('11', '17');
INSERT INTO `role_res` VALUES ('13', '17');
INSERT INTO `role_res` VALUES ('0', '17');
INSERT INTO `role_res` VALUES ('4', '18');
INSERT INTO `role_res` VALUES ('5', '18');
INSERT INTO `role_res` VALUES ('6', '18');
INSERT INTO `role_res` VALUES ('10', '18');
INSERT INTO `role_res` VALUES ('11', '18');
INSERT INTO `role_res` VALUES ('13', '18');
INSERT INTO `role_res` VALUES ('0', '18');
INSERT INTO `role_res` VALUES ('4', '19');
INSERT INTO `role_res` VALUES ('5', '19');
INSERT INTO `role_res` VALUES ('6', '19');
INSERT INTO `role_res` VALUES ('10', '19');
INSERT INTO `role_res` VALUES ('11', '19');
INSERT INTO `role_res` VALUES ('13', '19');
INSERT INTO `role_res` VALUES ('0', '19');
INSERT INTO `role_res` VALUES ('4', '20');
INSERT INTO `role_res` VALUES ('5', '20');
INSERT INTO `role_res` VALUES ('6', '20');
INSERT INTO `role_res` VALUES ('10', '20');
INSERT INTO `role_res` VALUES ('11', '20');
INSERT INTO `role_res` VALUES ('13', '20');
INSERT INTO `role_res` VALUES ('0', '20');
INSERT INTO `role_res` VALUES ('4', '21');
INSERT INTO `role_res` VALUES ('5', '21');
INSERT INTO `role_res` VALUES ('6', '21');
INSERT INTO `role_res` VALUES ('10', '21');
INSERT INTO `role_res` VALUES ('11', '21');
INSERT INTO `role_res` VALUES ('13', '21');
INSERT INTO `role_res` VALUES ('0', '21');
INSERT INTO `role_res` VALUES ('9', '2');
INSERT INTO `role_res` VALUES ('9', '8');
INSERT INTO `role_res` VALUES ('9', '9');
INSERT INTO `role_res` VALUES ('9', '11');
INSERT INTO `role_res` VALUES ('9', '12');
INSERT INTO `role_res` VALUES ('9', '13');
INSERT INTO `role_res` VALUES ('9', '14');
INSERT INTO `role_res` VALUES ('9', '15');
INSERT INTO `role_res` VALUES ('9', '16');
INSERT INTO `role_res` VALUES ('9', '18');
INSERT INTO `role_res` VALUES ('9', '19');
INSERT INTO `role_res` VALUES ('9', '20');
INSERT INTO `role_res` VALUES ('9', '21');
INSERT INTO `role_res` VALUES ('7', '2');
INSERT INTO `role_res` VALUES ('7', '4');
INSERT INTO `role_res` VALUES ('7', '5');
INSERT INTO `role_res` VALUES ('7', '6');
INSERT INTO `role_res` VALUES ('7', '8');
INSERT INTO `role_res` VALUES ('7', '9');
INSERT INTO `role_res` VALUES ('7', '10');
INSERT INTO `role_res` VALUES ('7', '11');
INSERT INTO `role_res` VALUES ('7', '12');
INSERT INTO `role_res` VALUES ('7', '13');
INSERT INTO `role_res` VALUES ('7', '14');
INSERT INTO `role_res` VALUES ('7', '15');
INSERT INTO `role_res` VALUES ('7', '16');
INSERT INTO `role_res` VALUES ('7', '17');
INSERT INTO `role_res` VALUES ('7', '19');
INSERT INTO `role_res` VALUES ('8', '2');
INSERT INTO `role_res` VALUES ('8', '4');
INSERT INTO `role_res` VALUES ('8', '5');
INSERT INTO `role_res` VALUES ('8', '6');
INSERT INTO `role_res` VALUES ('8', '8');
INSERT INTO `role_res` VALUES ('8', '9');
INSERT INTO `role_res` VALUES ('8', '10');
INSERT INTO `role_res` VALUES ('8', '11');
INSERT INTO `role_res` VALUES ('8', '12');
INSERT INTO `role_res` VALUES ('8', '13');
INSERT INTO `role_res` VALUES ('8', '14');
INSERT INTO `role_res` VALUES ('8', '15');
INSERT INTO `role_res` VALUES ('8', '16');
INSERT INTO `role_res` VALUES ('8', '17');
INSERT INTO `role_res` VALUES ('8', '19');
INSERT INTO `role_res` VALUES ('1', '2');
INSERT INTO `role_res` VALUES ('12', '2');
INSERT INTO `role_res` VALUES ('3', '2');
INSERT INTO `role_res` VALUES ('1234', '2');
INSERT INTO `role_res` VALUES ('1', '4');
INSERT INTO `role_res` VALUES ('1', '5');
INSERT INTO `role_res` VALUES ('1', '6');
INSERT INTO `role_res` VALUES ('12', '5');
INSERT INTO `role_res` VALUES ('12', '6');
INSERT INTO `role_res` VALUES ('3', '5');
INSERT INTO `role_res` VALUES ('3', '6');
INSERT INTO `role_res` VALUES ('1234', '5');
INSERT INTO `role_res` VALUES ('1234', '6');
INSERT INTO `role_res` VALUES ('12', '4');
INSERT INTO `role_res` VALUES ('1', '5');
INSERT INTO `role_res` VALUES ('1', '6');
INSERT INTO `role_res` VALUES ('12', '5');
INSERT INTO `role_res` VALUES ('12', '6');
INSERT INTO `role_res` VALUES ('3', '5');
INSERT INTO `role_res` VALUES ('3', '6');
INSERT INTO `role_res` VALUES ('1234', '5');
INSERT INTO `role_res` VALUES ('1234', '6');
INSERT INTO `role_res` VALUES ('3', '4');
INSERT INTO `role_res` VALUES ('1', '5');
INSERT INTO `role_res` VALUES ('1', '6');
INSERT INTO `role_res` VALUES ('12', '5');
INSERT INTO `role_res` VALUES ('12', '6');
INSERT INTO `role_res` VALUES ('3', '5');
INSERT INTO `role_res` VALUES ('3', '6');
INSERT INTO `role_res` VALUES ('1234', '5');
INSERT INTO `role_res` VALUES ('1234', '6');
INSERT INTO `role_res` VALUES ('1234', '4');
INSERT INTO `role_res` VALUES ('1', '5');
INSERT INTO `role_res` VALUES ('1', '6');
INSERT INTO `role_res` VALUES ('12', '5');
INSERT INTO `role_res` VALUES ('12', '6');
INSERT INTO `role_res` VALUES ('3', '5');
INSERT INTO `role_res` VALUES ('3', '6');
INSERT INTO `role_res` VALUES ('1234', '5');
INSERT INTO `role_res` VALUES ('1234', '6');
INSERT INTO `role_res` VALUES ('1', '8');
INSERT INTO `role_res` VALUES ('12', '8');
INSERT INTO `role_res` VALUES ('3', '8');
INSERT INTO `role_res` VALUES ('1234', '8');
INSERT INTO `role_res` VALUES ('1', '9');
INSERT INTO `role_res` VALUES ('12', '9');
INSERT INTO `role_res` VALUES ('3', '9');
INSERT INTO `role_res` VALUES ('1234', '9');
INSERT INTO `role_res` VALUES ('1', '10');
INSERT INTO `role_res` VALUES ('12', '10');
INSERT INTO `role_res` VALUES ('3', '10');
INSERT INTO `role_res` VALUES ('1234', '10');
INSERT INTO `role_res` VALUES ('1', '11');
INSERT INTO `role_res` VALUES ('12', '11');
INSERT INTO `role_res` VALUES ('3', '11');
INSERT INTO `role_res` VALUES ('1234', '11');
INSERT INTO `role_res` VALUES ('1', '12');
INSERT INTO `role_res` VALUES ('12', '12');
INSERT INTO `role_res` VALUES ('3', '12');
INSERT INTO `role_res` VALUES ('1234', '12');
INSERT INTO `role_res` VALUES ('1', '13');
INSERT INTO `role_res` VALUES ('12', '13');
INSERT INTO `role_res` VALUES ('3', '13');
INSERT INTO `role_res` VALUES ('1234', '13');
INSERT INTO `role_res` VALUES ('1', '14');
INSERT INTO `role_res` VALUES ('12', '14');
INSERT INTO `role_res` VALUES ('3', '14');
INSERT INTO `role_res` VALUES ('1234', '14');
INSERT INTO `role_res` VALUES ('1', '15');
INSERT INTO `role_res` VALUES ('12', '15');
INSERT INTO `role_res` VALUES ('3', '15');
INSERT INTO `role_res` VALUES ('1234', '15');
INSERT INTO `role_res` VALUES ('1', '16');
INSERT INTO `role_res` VALUES ('12', '16');
INSERT INTO `role_res` VALUES ('3', '16');
INSERT INTO `role_res` VALUES ('1234', '16');
INSERT INTO `role_res` VALUES ('1', '17');
INSERT INTO `role_res` VALUES ('12', '17');
INSERT INTO `role_res` VALUES ('3', '17');
INSERT INTO `role_res` VALUES ('1234', '17');
INSERT INTO `role_res` VALUES ('1', '20');
INSERT INTO `role_res` VALUES ('12', '20');
INSERT INTO `role_res` VALUES ('3', '20');
INSERT INTO `role_res` VALUES ('1234', '20');
INSERT INTO `role_res` VALUES ('1', '21');
INSERT INTO `role_res` VALUES ('12', '21');
INSERT INTO `role_res` VALUES ('3', '21');
INSERT INTO `role_res` VALUES ('1234', '21');

-- ----------------------------
-- Table structure for `test`
-- ----------------------------
DROP TABLE IF EXISTS `test`;
CREATE TABLE `test` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `pId` varchar(255) DEFAULT NULL,
  `zId` varchar(255) DEFAULT NULL,
  `sx` varchar(255) DEFAULT NULL,
  `parentId` varchar(255) DEFAULT NULL,
  `parentId2` varchar(255) DEFAULT NULL,
  `bh` int(11) DEFAULT '0',
  `lzId` varchar(225) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=516 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of test
-- ----------------------------
INSERT INTO `test` VALUES ('22', '58', '47', '878', '8', '88', '0', null);
INSERT INTO `test` VALUES ('277', '12', '1', '1', null, '81770998', '1', '12-001-001');
INSERT INTO `test` VALUES ('278', '12', '3', '热', '0', '81770998', '1', '12-001-001');
INSERT INTO `test` VALUES ('279', '12', '2', '6', null, '81770998', '1', '12-001-001');
INSERT INTO `test` VALUES ('280', '12', '4', '2018/12/20 15:07', null, '81770998', '1', '12-001-001');
INSERT INTO `test` VALUES ('281', '12', '5', '2018/12/11 15:07', null, '81770998', '1', '12-001-001');
INSERT INTO `test` VALUES ('282', '12', '6', '2018/12/11 15:07', null, '81770998', '1', '12-001-001');
INSERT INTO `test` VALUES ('283', '12', '7', '的观点突然热', null, '81770998', '1', '12-001-001');
INSERT INTO `test` VALUES ('284', '12', '8', ' 龈乳头炎', null, '81770998', '1', '12-001-001');
INSERT INTO `test` VALUES ('285', '12', '9', '龈乳头炎', null, '81770998', '1', '12-001-001');
INSERT INTO `test` VALUES ('286', '12', '10', '3', null, '81770998', '1', '12-001-001');
INSERT INTO `test` VALUES ('287', '12', '1', '2', null, '67156205', '1', '12-001-001');
INSERT INTO `test` VALUES ('288', '12', '3', '人体', '0', '67156205', '1', '12-001-001');
INSERT INTO `test` VALUES ('289', '12', '2', '6', null, '67156205', '1', '12-001-001');
INSERT INTO `test` VALUES ('290', '12', '4', '2018/12/20 15:07', null, '67156205', '1', '12-001-001');
INSERT INTO `test` VALUES ('291', '12', '5', '2018/12/11 15:07', null, '67156205', '1', '12-001-001');
INSERT INTO `test` VALUES ('292', '12', '6', '回复的', null, '67156205', '1', '12-001-001');
INSERT INTO `test` VALUES ('293', '12', '7', '发过火', null, '67156205', '1', '12-001-001');
INSERT INTO `test` VALUES ('294', '12', '8', '好讨厌', null, '67156205', '1', '12-001-001');
INSERT INTO `test` VALUES ('295', '12', '9', '预热他', null, '67156205', '1', '12-001-001');
INSERT INTO `test` VALUES ('296', '12', '10', '34', null, '67156205', '1', '12-001-001');
INSERT INTO `test` VALUES ('297', '12', '11', '1', null, '-903673296', '1', '12-001-001');
INSERT INTO `test` VALUES ('298', '12', '12', 'tertiary', '278', '-903673296', '1', '12-001-001');
INSERT INTO `test` VALUES ('299', '12', '13', '3', null, '-903673296', '1', '12-001-001');
INSERT INTO `test` VALUES ('300', '12', '18', '梵蒂冈', null, '-903673296', '1', '12-001-001');
INSERT INTO `test` VALUES ('301', '12', '14', '3424', null, '-903673296', '1', '12-001-001');
INSERT INTO `test` VALUES ('302', '12', '15', '32424', null, '-903673296', '1', '12-001-001');
INSERT INTO `test` VALUES ('303', '12', '16', '3', null, '-903673296', '1', '12-001-001');
INSERT INTO `test` VALUES ('304', '12', '17', '34', null, '-903673296', '1', '12-001-001');
INSERT INTO `test` VALUES ('305', '12', '11', '2', null, '-851628960', '1', '12-001-001');
INSERT INTO `test` VALUES ('306', '12', '12', '热', '278', '-851628960', '1', '12-001-001');
INSERT INTO `test` VALUES ('307', '12', '13', '3', null, '-851628960', '1', '12-001-001');
INSERT INTO `test` VALUES ('308', '12', '18', '同仁堂', null, '-851628960', '1', '12-001-001');
INSERT INTO `test` VALUES ('309', '12', '14', '荣特尔43', null, '-851628960', '1', '12-001-001');
INSERT INTO `test` VALUES ('310', '12', '15', '43', null, '-851628960', '1', '12-001-001');
INSERT INTO `test` VALUES ('311', '12', '16', '453', null, '-851628960', '1', '12-001-001');
INSERT INTO `test` VALUES ('312', '12', '17', '354', null, '-851628960', '1', '12-001-001');
INSERT INTO `test` VALUES ('313', '12', '19', '2-12-1-1', null, '59009', '1', '12-001-001');
INSERT INTO `test` VALUES ('314', '12', '20', '1', null, '59009', '1', '12-001-001');
INSERT INTO `test` VALUES ('315', '12', '21', '苟富贵', '298', '59009', '1', '12-001-001');
INSERT INTO `test` VALUES ('316', '12', '22', '2', null, '59009', '1', '12-001-001');
INSERT INTO `test` VALUES ('317', '12', '23', '1', null, '59009', '1', '12-001-001');
INSERT INTO `test` VALUES ('318', '12', '24', '突然', null, '59009', '1', '12-001-001');
INSERT INTO `test` VALUES ('319', '12', '25', '453', null, '59009', '1', '12-001-001');
INSERT INTO `test` VALUES ('320', '12', '26', '645', null, '59009', '1', '12-001-001');
INSERT INTO `test` VALUES ('321', '12', '27', '546', null, '59009', '1', '12-001-001');
INSERT INTO `test` VALUES ('322', '12', '28', '456', null, '59009', '1', '12-001-001');
INSERT INTO `test` VALUES ('323', '12', '29', '46', null, '59009', '1', '12-001-001');
INSERT INTO `test` VALUES ('324', '12', '19', '2-12-1-2', null, '184302', '1', '12-001-001');
INSERT INTO `test` VALUES ('325', '12', '20', '2', null, '184302', '1', '12-001-001');
INSERT INTO `test` VALUES ('326', '12', '21', '435', '298', '184302', '1', '12-001-001');
INSERT INTO `test` VALUES ('327', '12', '22', '1', null, '184302', '1', '12-001-001');
INSERT INTO `test` VALUES ('328', '12', '23', '45456', null, '184302', '1', '12-001-001');
INSERT INTO `test` VALUES ('329', '12', '24', '同意', null, '184302', '1', '12-001-001');
INSERT INTO `test` VALUES ('330', '12', '25', '456', null, '184302', '1', '12-001-001');
INSERT INTO `test` VALUES ('331', '12', '26', '435', null, '184302', '1', '12-001-001');
INSERT INTO `test` VALUES ('332', '12', '27', '345', null, '184302', '1', '12-001-001');
INSERT INTO `test` VALUES ('333', '12', '28', '35', null, '184302', '1', '12-001-001');
INSERT INTO `test` VALUES ('334', '12', '29', '35', null, '184302', '1', '12-001-001');
INSERT INTO `test` VALUES ('335', '12', '1', '1', null, '21392514', '3', '12-002-001');
INSERT INTO `test` VALUES ('336', '12', '3', '而我是', '0', '21392514', '3', '12-002-001');
INSERT INTO `test` VALUES ('337', '12', '2', '6', null, '21392514', '3', '12-002-001');
INSERT INTO `test` VALUES ('338', '12', '4', '2018/12/7 15:22', null, '21392514', '3', '12-002-001');
INSERT INTO `test` VALUES ('339', '12', '5', '2018/12/10 15:19', null, '21392514', '3', '12-002-001');
INSERT INTO `test` VALUES ('340', '12', '6', '对方提供', null, '21392514', '3', '12-002-001');
INSERT INTO `test` VALUES ('341', '12', '7', ' 热头发', null, '21392514', '3', '12-002-001');
INSERT INTO `test` VALUES ('342', '12', '8', '返回给头发', null, '21392514', '3', '12-002-001');
INSERT INTO `test` VALUES ('343', '12', '9', '帮你们', null, '21392514', '3', '12-002-001');
INSERT INTO `test` VALUES ('344', '12', '10', '1', null, '21392514', '3', '12-002-001');
INSERT INTO `test` VALUES ('345', '12', '1', '2', null, '79617738', '3', '12-002-001');
INSERT INTO `test` VALUES ('346', '12', '3', '大范甘迪', '0', '79617738', '3', '12-002-001');
INSERT INTO `test` VALUES ('347', '12', '2', '6', null, '79617738', '3', '12-002-001');
INSERT INTO `test` VALUES ('348', '12', '4', '2018/12/4 15:19', null, '79617738', '3', '12-002-001');
INSERT INTO `test` VALUES ('349', '12', '5', '2018/12/20 15:19', null, '79617738', '3', '12-002-001');
INSERT INTO `test` VALUES ('350', '12', '6', '尔萨日', null, '79617738', '3', '12-002-001');
INSERT INTO `test` VALUES ('351', '12', '7', '的个', null, '79617738', '3', '12-002-001');
INSERT INTO `test` VALUES ('352', '12', '8', '大哥', null, '79617738', '3', '12-002-001');
INSERT INTO `test` VALUES ('353', '12', '9', '对人体', null, '79617738', '3', '12-002-001');
INSERT INTO `test` VALUES ('354', '12', '10', '3', null, '79617738', '3', '12-002-001');
INSERT INTO `test` VALUES ('355', '1342', '19', '1342-1342-1', null, '33617', '1', '1342-001-001');
INSERT INTO `test` VALUES ('356', '1342', '20', '1', null, '33617', '1', '1342-001-001');
INSERT INTO `test` VALUES ('357', '1342', '21', '中国', '0', '33617', '1', '1342-001-001');
INSERT INTO `test` VALUES ('358', '1342', '22', '5', null, '33617', '1', '1342-001-001');
INSERT INTO `test` VALUES ('359', '1342', '23', '1', null, '33617', '1', '1342-001-001');
INSERT INTO `test` VALUES ('360', '1342', '24', '张三', null, '33617', '1', '1342-001-001');
INSERT INTO `test` VALUES ('361', '1342', '25', '2018/12/25 21:45', null, '33617', '1', '1342-001-001');
INSERT INTO `test` VALUES ('362', '1342', '26', '2017', null, '33617', '1', '1342-001-001');
INSERT INTO `test` VALUES ('363', '1342', '27', '2', null, '33617', '1', '1342-001-001');
INSERT INTO `test` VALUES ('364', '1342', '28', '1', null, '33617', '1', '1342-001-001');
INSERT INTO `test` VALUES ('365', '1342', '29', '1', null, '33617', '1', '1342-001-001');
INSERT INTO `test` VALUES ('366', '1342', '19', '1342-1342-2', null, '83354', '1', '1342-001-001');
INSERT INTO `test` VALUES ('367', '1342', '20', '2', null, '83354', '1', '1342-001-001');
INSERT INTO `test` VALUES ('368', '1342', '21', '美国', '0', '83354', '1', '1342-001-001');
INSERT INTO `test` VALUES ('369', '1342', '22', '6', null, '83354', '1', '1342-001-001');
INSERT INTO `test` VALUES ('370', '1342', '23', '2', null, '83354', '1', '1342-001-001');
INSERT INTO `test` VALUES ('371', '1342', '24', '李四', null, '83354', '1', '1342-001-001');
INSERT INTO `test` VALUES ('372', '1342', '25', '2018/12/25 21:45', null, '83354', '1', '1342-001-001');
INSERT INTO `test` VALUES ('373', '1342', '26', '2016', null, '83354', '1', '1342-001-001');
INSERT INTO `test` VALUES ('374', '1342', '27', '2', null, '83354', '1', '1342-001-001');
INSERT INTO `test` VALUES ('375', '1342', '28', '1', null, '83354', '1', '1342-001-001');
INSERT INTO `test` VALUES ('376', '1342', '29', '1', null, '83354', '1', '1342-001-001');
INSERT INTO `test` VALUES ('377', '1342', '19', '1342-1342-1', null, '57179', '5', '1342-003-001');
INSERT INTO `test` VALUES ('378', '1342', '20', '1', null, '57179', '5', '1342-003-001');
INSERT INTO `test` VALUES ('379', '1342', '21', '123', '0', '57179', '5', '1342-003-001');
INSERT INTO `test` VALUES ('380', '1342', '22', '5', null, '57179', '5', '1342-003-001');
INSERT INTO `test` VALUES ('381', '1342', '23', '12', null, '57179', '5', '1342-003-001');
INSERT INTO `test` VALUES ('382', '1342', '24', '123', null, '57179', '5', '1342-003-001');
INSERT INTO `test` VALUES ('383', '1342', '25', '2018/12/26 11:03', null, '57179', '5', '1342-003-001');
INSERT INTO `test` VALUES ('384', '1342', '26', '123', null, '57179', '5', '1342-003-001');
INSERT INTO `test` VALUES ('385', '1342', '27', '12', null, '57179', '5', '1342-003-001');
INSERT INTO `test` VALUES ('386', '1342', '28', '12', null, '57179', '5', '1342-003-001');
INSERT INTO `test` VALUES ('387', '1342', '29', '123', null, '57179', '5', '1342-003-001');
INSERT INTO `test` VALUES ('388', '1342', '19', '1342-1342-2', null, '25158', '5', '1342-003-001');
INSERT INTO `test` VALUES ('389', '1342', '20', '2', null, '25158', '5', '1342-003-001');
INSERT INTO `test` VALUES ('390', '1342', '21', '123', '0', '25158', '5', '1342-003-001');
INSERT INTO `test` VALUES ('391', '1342', '22', '6', null, '25158', '5', '1342-003-001');
INSERT INTO `test` VALUES ('392', '1342', '23', '123', null, '25158', '5', '1342-003-001');
INSERT INTO `test` VALUES ('393', '1342', '24', '123', null, '25158', '5', '1342-003-001');
INSERT INTO `test` VALUES ('394', '1342', '25', '2018/12/26 11:03', null, '25158', '5', '1342-003-001');
INSERT INTO `test` VALUES ('395', '1342', '26', '123', null, '25158', '5', '1342-003-001');
INSERT INTO `test` VALUES ('396', '1342', '27', '123', null, '25158', '5', '1342-003-001');
INSERT INTO `test` VALUES ('397', '1342', '28', '12', null, '25158', '5', '1342-003-001');
INSERT INTO `test` VALUES ('398', '1342', '29', '321', null, '25158', '5', '1342-003-001');
INSERT INTO `test` VALUES ('399', '1342', '19', '1342-1342-3', null, '11103', '6', '1342-003-001');
INSERT INTO `test` VALUES ('400', '1342', '20', '3', null, '11103', '6', '1342-003-001');
INSERT INTO `test` VALUES ('401', '1342', '21', '12', '0', '11103', '6', '1342-003-001');
INSERT INTO `test` VALUES ('402', '1342', '22', '11', null, '11103', '6', '1342-003-001');
INSERT INTO `test` VALUES ('403', '1342', '23', '12', null, '11103', '6', '1342-003-001');
INSERT INTO `test` VALUES ('404', '1342', '24', '213', null, '11103', '6', '1342-003-001');
INSERT INTO `test` VALUES ('405', '1342', '25', '2018/12/26 11:03', null, '11103', '6', '1342-003-001');
INSERT INTO `test` VALUES ('406', '1342', '26', '12', null, '11103', '6', '1342-003-001');
INSERT INTO `test` VALUES ('407', '1342', '27', '1', null, '11103', '6', '1342-003-001');
INSERT INTO `test` VALUES ('408', '1342', '28', '1', null, '11103', '6', '1342-003-001');
INSERT INTO `test` VALUES ('409', '1342', '29', '1', null, '11103', '6', '1342-003-001');
INSERT INTO `test` VALUES ('410', '1342', '19', '1342-1342-1', null, '95247', '1', '1342-002-001');
INSERT INTO `test` VALUES ('411', '1342', '20', '1', null, '95247', '1', '1342-002-001');
INSERT INTO `test` VALUES ('412', '1342', '21', '21', '0', '95247', '1', '1342-002-001');
INSERT INTO `test` VALUES ('413', '1342', '22', '11', null, '95247', '1', '1342-002-001');
INSERT INTO `test` VALUES ('414', '1342', '23', '1', null, '95247', '1', '1342-002-001');
INSERT INTO `test` VALUES ('415', '1342', '24', '2', null, '95247', '1', '1342-002-001');
INSERT INTO `test` VALUES ('416', '1342', '25', '', null, '95247', '1', '1342-002-001');
INSERT INTO `test` VALUES ('417', '1342', '26', '', null, '95247', '1', '1342-002-001');
INSERT INTO `test` VALUES ('418', '1342', '27', '', null, '95247', '1', '1342-002-001');
INSERT INTO `test` VALUES ('419', '1342', '28', '', null, '95247', '1', '1342-002-001');
INSERT INTO `test` VALUES ('420', '1342', '29', '', null, '95247', '1', '1342-002-001');
INSERT INTO `test` VALUES ('421', '1342', '19', '1342-1342-1', null, '88226', '7', '1342-004-001');
INSERT INTO `test` VALUES ('422', '1342', '20', '1', null, '88226', '7', '1342-004-001');
INSERT INTO `test` VALUES ('423', '1342', '21', '1', '0', '88226', '7', '1342-004-001');
INSERT INTO `test` VALUES ('424', '1342', '22', '11', null, '88226', '7', '1342-004-001');
INSERT INTO `test` VALUES ('425', '1342', '23', '', null, '88226', '7', '1342-004-001');
INSERT INTO `test` VALUES ('426', '1342', '24', '', null, '88226', '7', '1342-004-001');
INSERT INTO `test` VALUES ('427', '1342', '25', '', null, '88226', '7', '1342-004-001');
INSERT INTO `test` VALUES ('428', '1342', '26', '', null, '88226', '7', '1342-004-001');
INSERT INTO `test` VALUES ('429', '1342', '27', '', null, '88226', '7', '1342-004-001');
INSERT INTO `test` VALUES ('430', '1342', '28', '', null, '88226', '7', '1342-004-001');
INSERT INTO `test` VALUES ('431', '1342', '29', '', null, '88226', '7', '1342-004-001');
INSERT INTO `test` VALUES ('432', '1342', '19', '1342-1342-2', null, '77616', '8', '1342-004-001');
INSERT INTO `test` VALUES ('433', '1342', '20', '2', null, '77616', '8', '1342-004-001');
INSERT INTO `test` VALUES ('434', '1342', '21', '2', '0', '77616', '8', '1342-004-001');
INSERT INTO `test` VALUES ('435', '1342', '22', '11', null, '77616', '8', '1342-004-001');
INSERT INTO `test` VALUES ('436', '1342', '23', '', null, '77616', '8', '1342-004-001');
INSERT INTO `test` VALUES ('437', '1342', '24', '', null, '77616', '8', '1342-004-001');
INSERT INTO `test` VALUES ('438', '1342', '25', '', null, '77616', '8', '1342-004-001');
INSERT INTO `test` VALUES ('439', '1342', '26', '', null, '77616', '8', '1342-004-001');
INSERT INTO `test` VALUES ('440', '1342', '27', '', null, '77616', '8', '1342-004-001');
INSERT INTO `test` VALUES ('441', '1342', '28', '', null, '77616', '8', '1342-004-001');
INSERT INTO `test` VALUES ('442', '1342', '29', '', null, '77616', '8', '1342-004-001');
INSERT INTO `test` VALUES ('443', '1342', '19', '1342-1342-1', null, '59972', '11', '1342-005-001');
INSERT INTO `test` VALUES ('444', '1342', '20', '1', null, '59972', '11', '1342-005-001');
INSERT INTO `test` VALUES ('445', '1342', '21', '1', '0', '59972', '11', '1342-005-001');
INSERT INTO `test` VALUES ('446', '1342', '22', '11', null, '59972', '11', '1342-005-001');
INSERT INTO `test` VALUES ('447', '1342', '23', '', null, '59972', '11', '1342-005-001');
INSERT INTO `test` VALUES ('448', '1342', '24', '', null, '59972', '11', '1342-005-001');
INSERT INTO `test` VALUES ('449', '1342', '25', '', null, '59972', '11', '1342-005-001');
INSERT INTO `test` VALUES ('450', '1342', '26', '', null, '59972', '11', '1342-005-001');
INSERT INTO `test` VALUES ('451', '1342', '27', '', null, '59972', '11', '1342-005-001');
INSERT INTO `test` VALUES ('452', '1342', '28', '', null, '59972', '11', '1342-005-001');
INSERT INTO `test` VALUES ('453', '1342', '29', '', null, '59972', '11', '1342-005-001');
INSERT INTO `test` VALUES ('454', '1342', '19', '1342-1342-2', null, '99472', '12', '1342-005-001');
INSERT INTO `test` VALUES ('455', '1342', '20', '2', null, '99472', '12', '1342-005-001');
INSERT INTO `test` VALUES ('456', '1342', '21', '2', '0', '99472', '12', '1342-005-001');
INSERT INTO `test` VALUES ('457', '1342', '22', '11', null, '99472', '12', '1342-005-001');
INSERT INTO `test` VALUES ('458', '1342', '23', '', null, '99472', '12', '1342-005-001');
INSERT INTO `test` VALUES ('459', '1342', '24', '', null, '99472', '12', '1342-005-001');
INSERT INTO `test` VALUES ('460', '1342', '25', '', null, '99472', '12', '1342-005-001');
INSERT INTO `test` VALUES ('461', '1342', '26', '', null, '99472', '12', '1342-005-001');
INSERT INTO `test` VALUES ('462', '1342', '27', '', null, '99472', '12', '1342-005-001');
INSERT INTO `test` VALUES ('463', '1342', '28', '', null, '99472', '12', '1342-005-001');
INSERT INTO `test` VALUES ('464', '1342', '29', '', null, '99472', '12', '1342-005-001');
INSERT INTO `test` VALUES ('465', '1342', '19', '1342-1342-1', null, '1905', '13', '1342-006-001');
INSERT INTO `test` VALUES ('466', '1342', '20', '1', null, '1905', '13', '1342-006-001');
INSERT INTO `test` VALUES ('467', '1342', '21', '1', '0', '1905', '13', '1342-006-001');
INSERT INTO `test` VALUES ('468', '1342', '22', '11', null, '1905', '13', '1342-006-001');
INSERT INTO `test` VALUES ('469', '1342', '23', '', null, '1905', '13', '1342-006-001');
INSERT INTO `test` VALUES ('470', '1342', '24', '', null, '1905', '13', '1342-006-001');
INSERT INTO `test` VALUES ('471', '1342', '25', '', null, '1905', '13', '1342-006-001');
INSERT INTO `test` VALUES ('472', '1342', '26', '', null, '1905', '13', '1342-006-001');
INSERT INTO `test` VALUES ('473', '1342', '27', '', null, '1905', '13', '1342-006-001');
INSERT INTO `test` VALUES ('474', '1342', '28', '', null, '1905', '13', '1342-006-001');
INSERT INTO `test` VALUES ('475', '1342', '29', '', null, '1905', '13', '1342-006-001');
INSERT INTO `test` VALUES ('476', '1342', '19', '1342-1342-2', null, '122604', '14', '1342-006-001');
INSERT INTO `test` VALUES ('477', '1342', '20', '2', null, '122604', '14', '1342-006-001');
INSERT INTO `test` VALUES ('478', '1342', '21', '2', '0', '122604', '14', '1342-006-001');
INSERT INTO `test` VALUES ('479', '1342', '22', '11', null, '122604', '14', '1342-006-001');
INSERT INTO `test` VALUES ('480', '1342', '23', '', null, '122604', '14', '1342-006-001');
INSERT INTO `test` VALUES ('481', '1342', '24', '', null, '122604', '14', '1342-006-001');
INSERT INTO `test` VALUES ('482', '1342', '25', '', null, '122604', '14', '1342-006-001');
INSERT INTO `test` VALUES ('483', '1342', '26', '', null, '122604', '14', '1342-006-001');
INSERT INTO `test` VALUES ('484', '1342', '27', '', null, '122604', '14', '1342-006-001');
INSERT INTO `test` VALUES ('485', '1342', '28', '', null, '122604', '14', '1342-006-001');
INSERT INTO `test` VALUES ('486', '1342', '29', '', null, '122604', '14', '1342-006-001');
INSERT INTO `test` VALUES ('487', '45634', '1', '1', null, '94441995', '1', '45634-001-001');
INSERT INTO `test` VALUES ('488', '45634', '3', '123', '0', '94441995', '1', '45634-001-001');
INSERT INTO `test` VALUES ('489', '45634', '2', '11', null, '94441995', '1', '45634-001-001');
INSERT INTO `test` VALUES ('490', '45634', '4', '', null, '94441995', '1', '45634-001-001');
INSERT INTO `test` VALUES ('491', '45634', '5', '', null, '94441995', '1', '45634-001-001');
INSERT INTO `test` VALUES ('492', '45634', '6', '', null, '94441995', '1', '45634-001-001');
INSERT INTO `test` VALUES ('493', '45634', '7', '', null, '94441995', '1', '45634-001-001');
INSERT INTO `test` VALUES ('494', '45634', '8', '', null, '94441995', '1', '45634-001-001');
INSERT INTO `test` VALUES ('495', '45634', '9', '', null, '94441995', '1', '45634-001-001');
INSERT INTO `test` VALUES ('496', '45634', '10', '', null, '94441995', '1', '45634-001-001');
INSERT INTO `test` VALUES ('497', '45634', '11', '1', null, '-1006575184', '1', '45634-001-001');
INSERT INTO `test` VALUES ('498', '45634', '12', '1', '488', '-1006575184', '1', '45634-001-001');
INSERT INTO `test` VALUES ('499', '45634', '13', '11', null, '-1006575184', '1', '45634-001-001');
INSERT INTO `test` VALUES ('500', '45634', '18', '', null, '-1006575184', '1', '45634-001-001');
INSERT INTO `test` VALUES ('501', '45634', '14', '', null, '-1006575184', '1', '45634-001-001');
INSERT INTO `test` VALUES ('502', '45634', '15', '', null, '-1006575184', '1', '45634-001-001');
INSERT INTO `test` VALUES ('503', '45634', '16', '', null, '-1006575184', '1', '45634-001-001');
INSERT INTO `test` VALUES ('504', '45634', '17', '', null, '-1006575184', '1', '45634-001-001');
INSERT INTO `test` VALUES ('505', '45634', '19', '123-45634-1', null, '54170', '1', '45634-001-001');
INSERT INTO `test` VALUES ('506', '45634', '20', '1', null, '54170', '1', '45634-001-001');
INSERT INTO `test` VALUES ('507', '45634', '21', '1', '498', '54170', '1', '45634-001-001');
INSERT INTO `test` VALUES ('508', '45634', '22', '11', null, '54170', '1', '45634-001-001');
INSERT INTO `test` VALUES ('509', '45634', '23', '', null, '54170', '1', '45634-001-001');
INSERT INTO `test` VALUES ('510', '45634', '24', '', null, '54170', '1', '45634-001-001');
INSERT INTO `test` VALUES ('511', '45634', '25', '', null, '54170', '1', '45634-001-001');
INSERT INTO `test` VALUES ('512', '45634', '26', '', null, '54170', '1', '45634-001-001');
INSERT INTO `test` VALUES ('513', '45634', '27', '', null, '54170', '1', '45634-001-001');
INSERT INTO `test` VALUES ('514', '45634', '28', '', null, '54170', '1', '45634-001-001');
INSERT INTO `test` VALUES ('515', '45634', '29', '', null, '54170', '1', '45634-001-001');

-- ----------------------------
-- Table structure for `test2`
-- ----------------------------
DROP TABLE IF EXISTS `test2`;
CREATE TABLE `test2` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `pId` varchar(255) DEFAULT NULL,
  `zId` varchar(255) DEFAULT NULL,
  `sx` varchar(255) DEFAULT NULL,
  `parentId` varchar(255) DEFAULT NULL,
  `parentId2` varchar(255) DEFAULT NULL,
  `bh` int(11) DEFAULT '0',
  `lzId` varchar(225) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=612 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of test2
-- ----------------------------
INSERT INTO `test2` VALUES ('22', '58', '47', '878', '8', '88', '0', null);
INSERT INTO `test2` VALUES ('564', '1342', '19', '1342-1342-1', null, '62752', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('565', '1342', '20', '1', null, '62752', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('566', '1342', '21', '韩国', '0', '62752', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('567', '1342', '22', '6', null, '62752', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('568', '1342', '23', '4', null, '62752', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('569', '1342', '24', '矛', null, '62752', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('570', '1342', '25', '2018/12/26 9:42', null, '62752', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('571', '1342', '26', '55', null, '62752', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('572', '1342', '27', '5', null, '62752', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('573', '1342', '28', '5', null, '62752', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('574', '1342', '29', '5', null, '62752', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('575', '1342', '19', '1342-1342-2', null, '185474', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('576', '1342', '20', '2', null, '185474', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('577', '1342', '21', '中国', '0', '185474', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('578', '1342', '22', '5', null, '185474', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('579', '1342', '23', '2', null, '185474', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('580', '1342', '24', '发一个', null, '185474', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('581', '1342', '25', '2018/12/26 9:42', null, '185474', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('582', '1342', '26', '2016', null, '185474', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('583', '1342', '27', '22', null, '185474', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('584', '1342', '28', '2', null, '185474', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('585', '1342', '29', '1', null, '185474', '1', '1342-001-001');
INSERT INTO `test2` VALUES ('586', '45634', '1', '1', null, '33734972', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('587', '45634', '3', '12', '0', '33734972', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('588', '45634', '2', '11', null, '33734972', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('589', '45634', '4', '2018/12/26 11:36', null, '33734972', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('590', '45634', '5', '', null, '33734972', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('591', '45634', '6', '', null, '33734972', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('592', '45634', '7', '', null, '33734972', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('593', '45634', '8', '', null, '33734972', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('594', '45634', '9', '', null, '33734972', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('595', '45634', '10', '', null, '33734972', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('596', '45634', '11', '1', null, '-1457817888', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('597', '45634', '12', '1q', '587', '-1457817888', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('598', '45634', '13', '5', null, '-1457817888', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('599', '45634', '18', '', null, '-1457817888', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('600', '45634', '14', '', null, '-1457817888', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('601', '45634', '15', '', null, '-1457817888', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('602', '45634', '16', '', null, '-1457817888', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('603', '45634', '17', '', null, '-1457817888', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('604', '45634', '11', '2', null, '1698627112', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('605', '45634', '12', '5', '587', '1698627112', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('606', '45634', '13', '6', null, '1698627112', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('607', '45634', '18', '', null, '1698627112', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('608', '45634', '14', '', null, '1698627112', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('609', '45634', '15', '', null, '1698627112', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('610', '45634', '16', '', null, '1698627112', '1', '45634-001-001');
INSERT INTO `test2` VALUES ('611', '45634', '17', '', null, '1698627112', '1', '45634-001-001');

-- ----------------------------
-- Table structure for `url`
-- ----------------------------
DROP TABLE IF EXISTS `url`;
CREATE TABLE `url` (
  `pId` varchar(255) DEFAULT NULL,
  `anId` varchar(255) DEFAULT NULL,
  `jianId` varchar(255) DEFAULT NULL,
  `url` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of url
-- ----------------------------

-- ----------------------------
-- Table structure for `user`
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `useId` int(11) NOT NULL COMMENT '用户账号',
  `username` varchar(155) NOT NULL COMMENT '用户名',
  `password` varchar(155) DEFAULT '' COMMENT '密码',
  `sex` varchar(155) DEFAULT NULL COMMENT '性别',
  `brithday` date DEFAULT NULL COMMENT '生日',
  `Origin` varchar(155) DEFAULT NULL COMMENT '籍贯',
  `marriage` varchar(155) DEFAULT NULL COMMENT '婚育',
  `employdate` date DEFAULT NULL COMMENT '入职日期',
  `historyrole` varchar(155) DEFAULT NULL COMMENT '历史角色',
  `nowrole` varchar(155) DEFAULT NULL COMMENT '岗位角色',
  `workdate` date DEFAULT NULL COMMENT '上岗日期',
  `telephone` varchar(255) DEFAULT NULL COMMENT '联系电话',
  `mail` varchar(255) DEFAULT NULL COMMENT '电子邮箱',
  `wangdian` varchar(255) DEFAULT NULL COMMENT '开户网点',
  `card` varchar(255) DEFAULT NULL COMMENT '银行卡号',
  PRIMARY KEY (`username`,`useId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC COMMENT='用户信息表';

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES ('1', '123', '123', '男', '2018-08-07', '12', '未婚', '2018-08-22', '管理员', '管理员', null, '13387475622', '1235666@qq.com', null, null);
INSERT INTO `user` VALUES ('12', '21', '1', '女', '2018-08-12', '4444', '已婚', '2018-08-09', '领取员', '拆分员', '2018-08-22', '18568965633', null, null, null);
INSERT INTO `user` VALUES ('3', '33', '33', '男', '2018-06-12', '5464564', '已婚', '2018-08-09', '管理员', '图处员', '2018-08-17', null, '564566@qq.com', null, null);
INSERT INTO `user` VALUES ('1234', '你好', '123', '男', '2018-08-15', '345345345', '未婚', '2018-08-15', '管理员', '管理员', '2018-08-15', null, null, null, null);

-- ----------------------------
-- Table structure for `zd`
-- ----------------------------
DROP TABLE IF EXISTS `zd`;
CREATE TABLE `zd` (
  `pId` varchar(255) DEFAULT NULL,
  `zd` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of zd
-- ----------------------------
INSERT INTO `zd` VALUES ('1342', '19');
INSERT INTO `zd` VALUES ('1342', '20');
INSERT INTO `zd` VALUES ('1342', '21');
INSERT INTO `zd` VALUES ('1342', '22');
INSERT INTO `zd` VALUES ('1342', '23  ');
INSERT INTO `zd` VALUES ('1342', '24');
INSERT INTO `zd` VALUES ('1342', '25');
INSERT INTO `zd` VALUES ('1342', '26');
INSERT INTO `zd` VALUES ('1342', '27');
INSERT INTO `zd` VALUES ('1342', '28');
INSERT INTO `zd` VALUES ('1342', '29');
INSERT INTO `zd` VALUES ('45634', '1');
INSERT INTO `zd` VALUES ('45634', '3');
INSERT INTO `zd` VALUES ('45634', '2');
INSERT INTO `zd` VALUES ('45634', '11');
INSERT INTO `zd` VALUES ('45634', '12');
INSERT INTO `zd` VALUES ('45634', '13');
INSERT INTO `zd` VALUES ('45634', '18');
INSERT INTO `zd` VALUES ('45634', '19');
INSERT INTO `zd` VALUES ('45634', '20');
INSERT INTO `zd` VALUES ('45634', '21');
INSERT INTO `zd` VALUES ('45634', '22');
INSERT INTO `zd` VALUES ('45634', '23  ');
INSERT INTO `zd` VALUES ('45634', '4');
INSERT INTO `zd` VALUES ('45634', '5');
INSERT INTO `zd` VALUES ('45634', '6');
INSERT INTO `zd` VALUES ('45634', '7');
INSERT INTO `zd` VALUES ('45634', '8');
INSERT INTO `zd` VALUES ('45634', '9');
INSERT INTO `zd` VALUES ('45634', '10');
INSERT INTO `zd` VALUES ('45634', '14');
INSERT INTO `zd` VALUES ('45634', '15');
INSERT INTO `zd` VALUES ('45634', '16');
INSERT INTO `zd` VALUES ('45634', '17');
INSERT INTO `zd` VALUES ('45634', '24');
INSERT INTO `zd` VALUES ('45634', '25');
INSERT INTO `zd` VALUES ('45634', '26');
INSERT INTO `zd` VALUES ('45634', '27');
INSERT INTO `zd` VALUES ('45634', '28');
INSERT INTO `zd` VALUES ('45634', '29');

-- ----------------------------
-- Table structure for `ziduan`
-- ----------------------------
DROP TABLE IF EXISTS `ziduan`;
CREATE TABLE `ziduan` (
  `zId` int(155) NOT NULL AUTO_INCREMENT,
  `zd` varchar(155) DEFAULT NULL,
  PRIMARY KEY (`zId`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of ziduan
-- ----------------------------
INSERT INTO `ziduan` VALUES ('1', '项目号');
INSERT INTO `ziduan` VALUES ('2', '总页数');
INSERT INTO `ziduan` VALUES ('3', '项目题名');
INSERT INTO `ziduan` VALUES ('4', '开始时间');
INSERT INTO `ziduan` VALUES ('5', '结束时间');
INSERT INTO `ziduan` VALUES ('6', '业主单位');
INSERT INTO `ziduan` VALUES ('7', '设计单位');
INSERT INTO `ziduan` VALUES ('8', '施工单位');
INSERT INTO `ziduan` VALUES ('9', '监理单位');
INSERT INTO `ziduan` VALUES ('10', '分类号');
INSERT INTO `ziduan` VALUES ('11', '案卷号');
INSERT INTO `ziduan` VALUES ('12', '案卷题名');
INSERT INTO `ziduan` VALUES ('13', '页数');
INSERT INTO `ziduan` VALUES ('14', '起止日期');
INSERT INTO `ziduan` VALUES ('15', '保管期限');
INSERT INTO `ziduan` VALUES ('16', '分类号');
INSERT INTO `ziduan` VALUES ('17', '密级');
INSERT INTO `ziduan` VALUES ('18', '责任人');
INSERT INTO `ziduan` VALUES ('19', '档号3');
INSERT INTO `ziduan` VALUES ('20', '件号');
INSERT INTO `ziduan` VALUES ('21', '文件题名');
INSERT INTO `ziduan` VALUES ('22', '页数');
INSERT INTO `ziduan` VALUES ('23', '页号');
INSERT INTO `ziduan` VALUES ('24', '责任者');
INSERT INTO `ziduan` VALUES ('25', '文件日期');
INSERT INTO `ziduan` VALUES ('26', '年度');
INSERT INTO `ziduan` VALUES ('27', '保管期限');
INSERT INTO `ziduan` VALUES ('28', '分类号');
INSERT INTO `ziduan` VALUES ('29', '密级');

-- ----------------------------
-- Table structure for `zl`
-- ----------------------------
DROP TABLE IF EXISTS `zl`;
CREATE TABLE `zl` (
  `lzId` varchar(255) DEFAULT NULL,
  `bh` int(20) DEFAULT NULL,
  `iszl` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of zl
-- ----------------------------
INSERT INTO `zl` VALUES ('12-001-001', '1', '1');
INSERT INTO `zl` VALUES ('12-002-001', '3', '1');
INSERT INTO `zl` VALUES ('1342-001-001', '1', '1');
INSERT INTO `zl` VALUES ('1342-003-001', '5', '1');
INSERT INTO `zl` VALUES ('1342-003-001', '6', '1');
INSERT INTO `zl` VALUES ('1342-002-001', '1', '1');
INSERT INTO `zl` VALUES ('1342-004-001', '7', '1');
INSERT INTO `zl` VALUES ('1342-004-001', '8', '1');
INSERT INTO `zl` VALUES ('1342-005-001', '11', '1');
INSERT INTO `zl` VALUES ('1342-005-001', '12', '1');
INSERT INTO `zl` VALUES ('1342-006-001', '13', '1');
INSERT INTO `zl` VALUES ('1342-006-001', '14', '1');
INSERT INTO `zl` VALUES ('45634-001-001', '1', '1');

-- ----------------------------
-- Table structure for `zl2`
-- ----------------------------
DROP TABLE IF EXISTS `zl2`;
CREATE TABLE `zl2` (
  `lzId` varchar(255) DEFAULT NULL,
  `bh` int(20) DEFAULT NULL,
  `iszl` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of zl2
-- ----------------------------
INSERT INTO `zl2` VALUES ('1342-001-001', '1', '1');
INSERT INTO `zl2` VALUES ('45634-001-001', '1', '1');

-- ----------------------------
-- Procedure structure for `sp`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp`()
BEGIN
  DECLARE newname INT;
  DECLARE xid INT;
  DECLARE done TINYINT DEFAULT 0;
  DECLARE cur1 CURSOR FOR SELECT pId, up FROM jd WHERE Lname = '打码';
  DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;
  OPEN cur1;
  read_loop: LOOP
    FETCH FROM cur1 INTO newname, xid;
    INSERT INTO to_data (pId, up) VALUES (newname, xid);
    IF done THEN LEAVE read_loop; END IF;
    SELECT newname, xid;
  END LOOP;
  CLOSE cur1;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `sp1`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp1`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp1`()
BEGIN
  DECLARE getpid INT;
  DECLARE getlid INT;
  DECLARE done TINYINT DEFAULT 0;
  DECLARE cur1 CURSOR FOR SELECT pId,LID FROM temp;
  DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;
  OPEN cur1;
  read_loop: LOOP
    FETCH FROM cur1 INTO getpid, getlid;                                                                                          
    -- 使用中间变量getpid和getlid时，将其放在过滤语句中不需要在前面加上@，直接使用即可
    INSERT INTO to_data SELECT pId, up FROM jd WHERE pId=getpid AND LID=getlid;
    IF done THEN LEAVE read_loop; END IF;
  END LOOP;
  CLOSE cur1;
END
;;
DELIMITER ;

-- ----------------------------
-- Procedure structure for `sp2`
-- ----------------------------
DROP PROCEDURE IF EXISTS `sp2`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp2`()
BEGIN
  DECLARE getpid INT;
  DECLARE getup INT;
  DECLARE done TINYINT DEFAULT 0;
  DECLARE cur2 CURSOR FOR SELECT pId,up FROM to_data;
  DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;
  OPEN cur2;
  read_loop: LOOP
    FETCH FROM cur2 INTO getpid, getup;                                                                                      
    -- 使用中间变量getpid和getlid时，将其放在过滤语句中不需要在前面加上@，直接使用即可
    INSERT INTO sel_data SELECT pId, LID, bh, status FROM nprocessing2 WHERE pId=getpid AND LID=getup AND status=1;
    IF done THEN LEAVE read_loop; END IF;
  END LOOP;
  CLOSE cur2;
END
;;
DELIMITER ;

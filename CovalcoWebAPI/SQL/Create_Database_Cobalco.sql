﻿USE MASTER
GO
IF NOT EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE NAME = N'FlywayDB')
	CREATE DATABASE [FlyWayDB]
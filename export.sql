--------------------------------------------------------
--  File created - Monday-May-09-2016   
--------------------------------------------------------
DROP TABLE "ERSHAD"."FACTOR_FROOSH" cascade constraints;
DROP TABLE "ERSHAD"."FACTOR_KHARID" cascade constraints;
DROP TABLE "ERSHAD"."KALA" cascade constraints;
DROP TABLE "ERSHAD"."MOSHTARI" cascade constraints;
DROP TABLE "ERSHAD"."PROVIDER" cascade constraints;
DROP PROCEDURE "ERSHAD"."PROC_DELETE_FF";
DROP PROCEDURE "ERSHAD"."PROC_DELETE_FK";
DROP PROCEDURE "ERSHAD"."PROC_DELETE_K";
DROP PROCEDURE "ERSHAD"."PROC_DELETE_M";
DROP PROCEDURE "ERSHAD"."PROC_DELETE_P";
DROP PROCEDURE "ERSHAD"."PROC_INSERT_FF";
DROP PROCEDURE "ERSHAD"."PROC_INSERT_K";
DROP PROCEDURE "ERSHAD"."PROC_INSERT_M";
DROP PROCEDURE "ERSHAD"."PROC_INSERT_P";
DROP PROCEDURE "ERSHAD"."PROC_UPDATE_K";
DROP PROCEDURE "ERSHAD"."PROC_UPDATE_M";
DROP PROCEDURE "ERSHAD"."PROC_UPDATE_P";
--------------------------------------------------------
--  DDL for Table FACTOR_FROOSH
--------------------------------------------------------

  CREATE TABLE "ERSHAD"."FACTOR_FROOSH" 
   (	"NO" NUMBER, 
	"IDMOSHTARI" NUMBER, 
	"IDKALA" NUMBER, 
	"PRICE" NUMBER, 
	"COUNT" NUMBER, 
	"FACTOR_DAY" NVARCHAR2(20)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table FACTOR_KHARID
--------------------------------------------------------

  CREATE TABLE "ERSHAD"."FACTOR_KHARID" 
   (	"NO" NUMBER, 
	"IDPROVIDER" NUMBER, 
	"IDKALA" NUMBER, 
	"PRICE" NUMBER, 
	"COUNT" NUMBER, 
	"FACTOR_DAY" NVARCHAR2(20)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table KALA
--------------------------------------------------------

  CREATE TABLE "ERSHAD"."KALA" 
   (	"ID" NUMBER, 
	"NAME" NVARCHAR2(20), 
	"BRAND" NVARCHAR2(20), 
	"TYPE" NVARCHAR2(20), 
	"PRICE" NUMBER
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table MOSHTARI
--------------------------------------------------------

  CREATE TABLE "ERSHAD"."MOSHTARI" 
   (	"ID" NUMBER, 
	"NAME" NVARCHAR2(20), 
	"FAMILY" NVARCHAR2(20), 
	"TEL" NVARCHAR2(20)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table PROVIDER
--------------------------------------------------------

  CREATE TABLE "ERSHAD"."PROVIDER" 
   (	"ID" NUMBER, 
	"COM_NAME" NVARCHAR2(20), 
	"COM_TEL" NVARCHAR2(20), 
	"COM_ADDR" NVARCHAR2(20), 
	"COM_TYPE" NVARCHAR2(20)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
REM INSERTING into ERSHAD.FACTOR_FROOSH
SET DEFINE OFF;
Insert into ERSHAD.FACTOR_FROOSH (NO,IDMOSHTARI,IDKALA,PRICE,COUNT,FACTOR_DAY) values (5500,1,101,50000,1,'94/1/20');
Insert into ERSHAD.FACTOR_FROOSH (NO,IDMOSHTARI,IDKALA,PRICE,COUNT,FACTOR_DAY) values (5560,3,110,80000,1,'94/5/3');
Insert into ERSHAD.FACTOR_FROOSH (NO,IDMOSHTARI,IDKALA,PRICE,COUNT,FACTOR_DAY) values (5580,1001,120,500000,5,'93/5/5');
Insert into ERSHAD.FACTOR_FROOSH (NO,IDMOSHTARI,IDKALA,PRICE,COUNT,FACTOR_DAY) values (6000,3,100,10000,2,'95/6/6');
Insert into ERSHAD.FACTOR_FROOSH (NO,IDMOSHTARI,IDKALA,PRICE,COUNT,FACTOR_DAY) values (6500,1001,101,20000,1,'95/2/6');
Insert into ERSHAD.FACTOR_FROOSH (NO,IDMOSHTARI,IDKALA,PRICE,COUNT,FACTOR_DAY) values (5000,1001,101,80000,1,'95/1/30');
REM INSERTING into ERSHAD.FACTOR_KHARID
SET DEFINE OFF;
Insert into ERSHAD.FACTOR_KHARID (NO,IDPROVIDER,IDKALA,PRICE,COUNT,FACTOR_DAY) values (10000,501,109,5000,2,'94/1/3');
Insert into ERSHAD.FACTOR_KHARID (NO,IDPROVIDER,IDKALA,PRICE,COUNT,FACTOR_DAY) values (10001,506,101,50000,1,'94/4/1');
Insert into ERSHAD.FACTOR_KHARID (NO,IDPROVIDER,IDKALA,PRICE,COUNT,FACTOR_DAY) values (10003,510,109,200000,6,'94/5/5');
Insert into ERSHAD.FACTOR_KHARID (NO,IDPROVIDER,IDKALA,PRICE,COUNT,FACTOR_DAY) values (10005,520,110,180100,2,'94/4/1');
Insert into ERSHAD.FACTOR_KHARID (NO,IDPROVIDER,IDKALA,PRICE,COUNT,FACTOR_DAY) values (10008,506,120,502100,1,'95/1/20');
Insert into ERSHAD.FACTOR_KHARID (NO,IDPROVIDER,IDKALA,PRICE,COUNT,FACTOR_DAY) values (10010,503,105,560000,2,'95/2/20');
REM INSERTING into ERSHAD.KALA
SET DEFINE OFF;
Insert into ERSHAD.KALA (ID,NAME,BRAND,TYPE,PRICE) values (100,'xxxx','sony','tv',150000);
Insert into ERSHAD.KALA (ID,NAME,BRAND,TYPE,PRICE) values (101,'yyy','samsung','ref',1200000);
Insert into ERSHAD.KALA (ID,NAME,BRAND,TYPE,PRICE) values (105,'cccc','Lg','ref',175000);
Insert into ERSHAD.KALA (ID,NAME,BRAND,TYPE,PRICE) values (109,'zzzz','Sony','TV',200000);
Insert into ERSHAD.KALA (ID,NAME,BRAND,TYPE,PRICE) values (110,'aaaa','Samsung','Vac Cleaner',150000);
Insert into ERSHAD.KALA (ID,NAME,BRAND,TYPE,PRICE) values (120,'zzz','Samsung','Tv',800000);
REM INSERTING into ERSHAD.MOSHTARI
SET DEFINE OFF;
Insert into ERSHAD.MOSHTARI (ID,NAME,FAMILY,TEL) values (230,'ershad','anjsdad','23y49824');
Insert into ERSHAD.MOSHTARI (ID,NAME,FAMILY,TEL) values (89,'eabdm','asdasd','asdasd');
Insert into ERSHAD.MOSHTARI (ID,NAME,FAMILY,TEL) values (1000,'ershad','raoufi','8937459');
Insert into ERSHAD.MOSHTARI (ID,NAME,FAMILY,TEL) values (3,'arash','tehrani','02121541');
Insert into ERSHAD.MOSHTARI (ID,NAME,FAMILY,TEL) values (1001,'xxx','adab','53453433');
Insert into ERSHAD.MOSHTARI (ID,NAME,FAMILY,TEL) values (1,'ershad','raoufi','08075087');
REM INSERTING into ERSHAD.PROVIDER
SET DEFINE OFF;
Insert into ERSHAD.PROVIDER (ID,COM_NAME,COM_TEL,COM_ADDR,COM_TYPE) values (89,'eabdm','asdasd','asdasd','asdasd');
Insert into ERSHAD.PROVIDER (ID,COM_NAME,COM_TEL,COM_ADDR,COM_TYPE) values (500,'XXX','32520001','karaj','Tv');
Insert into ERSHAD.PROVIDER (ID,COM_NAME,COM_TEL,COM_ADDR,COM_TYPE) values (501,'YYY','3250654654','Karaj','Ref');
Insert into ERSHAD.PROVIDER (ID,COM_NAME,COM_TEL,COM_ADDR,COM_TYPE) values (503,'GGG','65200059','Tehran','Tv');
Insert into ERSHAD.PROVIDER (ID,COM_NAME,COM_TEL,COM_ADDR,COM_TYPE) values (506,'KKK','54564600','Tehran','Tv');
Insert into ERSHAD.PROVIDER (ID,COM_NAME,COM_TEL,COM_ADDR,COM_TYPE) values (510,'abc','53435435','karaj','Ref');
Insert into ERSHAD.PROVIDER (ID,COM_NAME,COM_TEL,COM_ADDR,COM_TYPE) values (520,'vhngf','6565200','tehran','Tv');
--------------------------------------------------------
--  DDL for Index PK_KALA
--------------------------------------------------------

  CREATE UNIQUE INDEX "ERSHAD"."PK_KALA" ON "ERSHAD"."KALA" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index PK_MOSHTARI
--------------------------------------------------------

  CREATE UNIQUE INDEX "ERSHAD"."PK_MOSHTARI" ON "ERSHAD"."MOSHTARI" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index PK_NO
--------------------------------------------------------

  CREATE UNIQUE INDEX "ERSHAD"."PK_NO" ON "ERSHAD"."FACTOR_FROOSH" ("NO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index PK_NO_K
--------------------------------------------------------

  CREATE UNIQUE INDEX "ERSHAD"."PK_NO_K" ON "ERSHAD"."FACTOR_KHARID" ("NO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index PK_PROVIDER
--------------------------------------------------------

  CREATE UNIQUE INDEX "ERSHAD"."PK_PROVIDER" ON "ERSHAD"."PROVIDER" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  Constraints for Table FACTOR_FROOSH
--------------------------------------------------------

  ALTER TABLE "ERSHAD"."FACTOR_FROOSH" MODIFY ("NO" NOT NULL ENABLE);
  ALTER TABLE "ERSHAD"."FACTOR_FROOSH" ADD CONSTRAINT "PK_NO" PRIMARY KEY ("NO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table FACTOR_KHARID
--------------------------------------------------------

  ALTER TABLE "ERSHAD"."FACTOR_KHARID" MODIFY ("NO" NOT NULL ENABLE);
  ALTER TABLE "ERSHAD"."FACTOR_KHARID" ADD CONSTRAINT "PK_NO_K" PRIMARY KEY ("NO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table KALA
--------------------------------------------------------

  ALTER TABLE "ERSHAD"."KALA" ADD CONSTRAINT "PK_KALA" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table MOSHTARI
--------------------------------------------------------

  ALTER TABLE "ERSHAD"."MOSHTARI" ADD CONSTRAINT "PK_MOSHTARI" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Constraints for Table PROVIDER
--------------------------------------------------------

  ALTER TABLE "ERSHAD"."PROVIDER" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "ERSHAD"."PROVIDER" ADD CONSTRAINT "PK_PROVIDER" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table FACTOR_FROOSH
--------------------------------------------------------

  ALTER TABLE "ERSHAD"."FACTOR_FROOSH" ADD CONSTRAINT "FK_ID_K" FOREIGN KEY ("IDKALA")
	  REFERENCES "ERSHAD"."KALA" ("ID") ENABLE;
  ALTER TABLE "ERSHAD"."FACTOR_FROOSH" ADD CONSTRAINT "FK_ID_P" FOREIGN KEY ("IDMOSHTARI")
	  REFERENCES "ERSHAD"."MOSHTARI" ("ID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table FACTOR_KHARID
--------------------------------------------------------

  ALTER TABLE "ERSHAD"."FACTOR_KHARID" ADD CONSTRAINT "FK_F_K" FOREIGN KEY ("IDKALA")
	  REFERENCES "ERSHAD"."KALA" ("ID") ENABLE;
  ALTER TABLE "ERSHAD"."FACTOR_KHARID" ADD CONSTRAINT "FK_F_P" FOREIGN KEY ("IDPROVIDER")
	  REFERENCES "ERSHAD"."PROVIDER" ("ID") ENABLE;
--------------------------------------------------------
--  DDL for Procedure PROC_DELETE_FF
--------------------------------------------------------
set define off;

  CREATE OR REPLACE   PROCEDURE "ERSHAD"."PROC_DELETE_FF" 
(
  NOOO IN NUMBER 
) AS 
BEGIN
  delete from factor_froosh where NO = NOOO;
END PROC_DELETE_FF;

/
--------------------------------------------------------
--  DDL for Procedure PROC_DELETE_FK
--------------------------------------------------------
set define off;

  CREATE OR REPLACE   PROCEDURE "ERSHAD"."PROC_DELETE_FK" 
(
  NOOO IN NUMBER 
) AS 
BEGIN
  delete from factor_kharid where NO = NOOO;
END PROC_DELETE_fk;

/
--------------------------------------------------------
--  DDL for Procedure PROC_DELETE_K
--------------------------------------------------------
set define off;

  CREATE OR REPLACE   PROCEDURE "ERSHAD"."PROC_DELETE_K" 
(
  I IN NUMBER 
) AS 
BEGIN
 delete from Moshtari where id = I;
END PROC_DELETE_K;

/
--------------------------------------------------------
--  DDL for Procedure PROC_DELETE_M
--------------------------------------------------------
set define off;

  CREATE OR REPLACE   PROCEDURE "ERSHAD"."PROC_DELETE_M" 
(
  iid IN NUMBER 
) AS 
BEGIN
  delete from Moshtari where id = iid;
END PROC_DELETE_M;

/
--------------------------------------------------------
--  DDL for Procedure PROC_DELETE_P
--------------------------------------------------------
set define off;

  CREATE OR REPLACE   PROCEDURE "ERSHAD"."PROC_DELETE_P" 
(
  I IN NUMBER 
) AS 
BEGIN
  delete from kala where id = I;
END PROC_DELETE_P;

/
--------------------------------------------------------
--  DDL for Procedure PROC_INSERT_FF
--------------------------------------------------------
set define off;

  CREATE OR REPLACE   PROCEDURE "ERSHAD"."PROC_INSERT_FF" 
(
  I IN NUMBER 
, IM IN NUMBER 
, IK IN NUMBER 
, P IN NUMBER 
, C IN NUMBER 
, DAY IN VARCHAR2
) AS 
BEGIN
  insert into FACTOR_FROOSH(No,IDMOSHTARI,IDKALA,PRICE,COUNT,FACTOR_DAY) values(I,IM,IK,P,C,DAY);
END PROC_INSERT_FF;

/
--------------------------------------------------------
--  DDL for Procedure PROC_INSERT_K
--------------------------------------------------------
set define off;

  CREATE OR REPLACE   PROCEDURE "ERSHAD"."PROC_INSERT_K" 
(
  I IN NUMBER 
, N IN VARCHAR2 
, B IN VARCHAR2 
, T IN VARCHAR2 
, P IN NUMBER 
) AS 
BEGIN
  insert into KALA(ID,Name,Brand,TYPE,PRICE) values(I,N,B,T,P);
END PROC_INSERT_K;

/
--------------------------------------------------------
--  DDL for Procedure PROC_INSERT_M
--------------------------------------------------------
set define off;

  CREATE OR REPLACE   PROCEDURE "ERSHAD"."PROC_INSERT_M" 
(
  I IN VARCHAR2 
, N IN VARCHAR2 
, F IN VARCHAR2 
, T IN VARCHAR2 
) AS 
BEGIN
      insert into moshtari(Id,Name,Family,Tel) values(I,N,F,T);
END PROC_Insert_m;

/
--------------------------------------------------------
--  DDL for Procedure PROC_INSERT_P
--------------------------------------------------------
set define off;

  CREATE OR REPLACE   PROCEDURE "ERSHAD"."PROC_INSERT_P" 
(
  I IN NUMBER 
, CN IN VARCHAR2 
, CT IN VARCHAR2 
, CA IN VARCHAR2 
, CTYPE IN VARCHAR2 
) AS 
BEGIN
 insert into provider(id,com_name,com_tel,com_addr,com_type) values(I,CN,CT,CA,CTYPE);
END PROC_INSERT_P;

/
--------------------------------------------------------
--  DDL for Procedure PROC_UPDATE_K
--------------------------------------------------------
set define off;

  CREATE OR REPLACE   PROCEDURE "ERSHAD"."PROC_UPDATE_K" 
(
  I IN NUMBER 
, N IN VARCHAR2 
, B IN VARCHAR2 
, T IN VARCHAR2 
, P IN NUMBER 
) AS 
BEGIN
    update KALA
  set ID =  I, Name=N, BRAND=B , TYPE=T , PRICE=P where id = I;
END PROC_UPDATE_K;

/
--------------------------------------------------------
--  DDL for Procedure PROC_UPDATE_M
--------------------------------------------------------
set define off;

  CREATE OR REPLACE   PROCEDURE "ERSHAD"."PROC_UPDATE_M" 
(
  I IN NUMBER 
, N IN VARCHAR2 
, F IN VARCHAR2 
, T IN VARCHAR2 
) AS 
BEGIN
  update MOSHTARI
  set NAME =  N, family=F, TEL=T where id = I;
END PROC_UPDATE_M;

/
--------------------------------------------------------
--  DDL for Procedure PROC_UPDATE_P
--------------------------------------------------------
set define off;

  CREATE OR REPLACE   PROCEDURE "ERSHAD"."PROC_UPDATE_P" 
(
  I IN NUMBER 
, CN IN VARCHAR2 
, CT IN VARCHAR2 
, CA IN VARCHAR2 
, CTYPE IN VARCHAR2 
) AS 
BEGIN
  update PROVIDER
  set ID =  I, com_name=cn, com_tel=CT , com_ADDR=CA , Com_TYPE=CTYPE where id = I;
END PROC_UPDATE_P;

/

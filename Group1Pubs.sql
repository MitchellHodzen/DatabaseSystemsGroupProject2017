--Todo: Change some nullable values to non-nullable
--Publishers, keep last 2 values null?

use master

IF exists (SELECT * FROM sysdatabases WHERE name='Group1Pubs')
BEGIN
  raiserror('Dropping existing Group1Pubs database ....',0,1)
  DROP DATABASE Group1Pubs
END

CREATE DATABASE Group1Pubs
GO

use Group1Pubs
CREATE TABLE [AUTHOR]
( 
	[authorID]           varchar(11)  NOT NULL ,
	[authorFName]        varchar(20)  NOT NULL ,
	[authorLName]        varchar(40)  NOT NULL ,
	[phone]              char(12)     NOT NULL ,
	[address]            varchar(40)  NULL ,
	[city]               varchar(20)  NULL ,
	[state]              char(2)      NULL ,
	[zip]                char(5)      NULL ,
	[contract]           bit          NOT NULL 
)
go

ALTER TABLE [AUTHOR]
	ADD CONSTRAINT [XPKAUTHOR] PRIMARY KEY  CLUSTERED ([authorID] ASC)
go

CREATE TABLE [CUSTDISC]
( 
	[discountID]         smallint  NOT NULL ,
	[storeID]            char(4)  NOT NULL ,
	[pubID]              char(4)  NOT NULL 
)
go

ALTER TABLE [CUSTDISC]
	ADD CONSTRAINT [XPKCUSTDISC] PRIMARY KEY  CLUSTERED ([discountID] ASC,[pubID] ASC)
go

CREATE TABLE [DISCOUNT]
( 
	[discountID]         smallint IDENTITY(1,1),
	[pubID]              char(4)  NOT NULL ,
	[discountTypeDesc]   varchar(40)  NOT NULL ,
	[discountAmount]     money  NOT NULL 
)
go

ALTER TABLE [DISCOUNT]
	ADD CONSTRAINT [XPKDISCOUNT] PRIMARY KEY  CLUSTERED ([discountID] ASC,[pubID] ASC)
go

CREATE TABLE [EMPLOYMENT]
( 
	[SSN]                char(9)  NOT NULL ,
	[jobID]              smallint NOT NULL ,
	[job_lvl]            tinyint  NOT NULL ,
	[positionStartDate]  date     NOT NULL ,
	[pubID]              char(4)  NOT NULL 
)
go

ALTER TABLE [EMPLOYMENT]
	ADD CONSTRAINT [XPKEMPLOYMENT] PRIMARY KEY  CLUSTERED ([SSN] ASC,[jobID] ASC,[pubID] ASC)
go

CREATE TABLE [JOB]
( 
	[jobID]              smallint IDENTITY(1,1),
	[pubID]              char(4)   NOT NULL ,
	[jobDesc]            varchar(50)  NOT NULL ,
	[min_lvl]            tinyint  NOT NULL ,
	[max_lvl]            tinyint  NOT NULL 
)
go

ALTER TABLE [JOB]
	ADD CONSTRAINT [XPKJOB] PRIMARY KEY  CLUSTERED ([jobID] ASC,[pubID] ASC)
go

CREATE TABLE [PERSON]
( 
	[SSN]                char(9)  NOT NULL ,
	[personFName]        varchar(20)  NOT NULL ,
	[personLName]        varchar(30)  NOT NULL , 
	[personMInit]        char(1)  NULL 
)
go

ALTER TABLE [PERSON]
	ADD CONSTRAINT [XPKPERSON] PRIMARY KEY  CLUSTERED ([SSN] ASC)
go

CREATE TABLE [PUBLISHER]
( 
	[pubID]              char(4)  NOT NULL ,
	[pubName]            varchar(40)  NOT NULL ,
	[city]               varchar(20)  NULL ,
	[state]              char(2)  NULL ,
	[country]            varchar(30)  NULL ,
	[logo]               image  NULL ,
	[pr_info]            text  NULL 
)
go

ALTER TABLE [PUBLISHER]
	ADD CONSTRAINT [XPKPUBLISHER] PRIMARY KEY  CLUSTERED ([pubID] ASC)
go

CREATE TABLE [SALE]
( 
	[orderNO]            varchar(20)   NOT NULL ,
	[titleID]            varchar(6)  NOT NULL ,
	[storeID]            char(4)  NOT NULL ,
	[orderDate]          date  NOT NULL ,
	[quantity]           smallint  NOT NULL ,
	[payterms]           varchar(12)  NOT NULL 
)
go

ALTER TABLE [SALE]
	ADD CONSTRAINT [XPKSALE] PRIMARY KEY  CLUSTERED ([orderNO] ASC)
go

CREATE TABLE [SALEDISCOUNT]
( 
	[discountID]         smallint   NOT NULL ,
	[orderNO]            varchar(20) NOT NULL ,
	[pubID]              char(4)  NOT NULL 
)
go

ALTER TABLE [SALEDISCOUNT]
	ADD CONSTRAINT [XPKSALEDISCOUNT] PRIMARY KEY  CLUSTERED ([discountID] ASC,[orderNO] ASC,[pubID] ASC)
go

CREATE TABLE [STORE]
( 
	[storeID]            char(4)  NOT NULL ,
	[storeName]          varchar(40)  NOT NULL ,
	[address]            varchar(40)  NULL ,
	[city]               varchar(20)  NULL ,
	[state]              char(2)  NULL ,
	[zip]                char(5)  NULL 
)
go

ALTER TABLE [STORE]
	ADD CONSTRAINT [XPKSTORE] PRIMARY KEY  CLUSTERED ([storeID] ASC)
go

CREATE TABLE [TITLE]
( 
	[titleID]            varchar(6)  NOT NULL ,
	[pubID]              char(4)  NOT NULL ,
	[title]              varchar(80)  NOT NULL ,
	[type]               char(12)  NULL ,
	[TypeList]           char(18)  NULL , --keep?
	[price]              money  NULL ,
	[advance]            money  NULL ,
	[royalty]            int  NULL ,
	[notes]              varchar(200)  NULL ,
	[pubdate]            datetime  NULL 
)
go

ALTER TABLE [TITLE]
	ADD CONSTRAINT [XPKTITLE] PRIMARY KEY  CLUSTERED ([titleID] ASC)
go

CREATE TABLE [TITLEAUTHOR]
( 
	[titleID]            varchar(6)  NOT NULL ,
	[authorID]           varchar(11)  NOT NULL ,
	[authorOrder]        tinyint  NULL ,
	[royaltyPer]         int  NULL 
)
go

ALTER TABLE [TITLEAUTHOR]
	ADD CONSTRAINT [XPKTITLEAUTHOR] PRIMARY KEY  CLUSTERED ([titleID] ASC,[authorID] ASC)
go

CREATE TABLE [VOLUMEDISC]
( 
	[discountID]         smallint  NOT NULL ,
	[lowQty]             smallint  NOT NULL ,
	[highQty]            smallint  NOT NULL ,
	[pubID]              char(4)  NOT NULL 
)
go

ALTER TABLE [VOLUMEDISC]
	ADD CONSTRAINT [XPKVOLUMEDISC] PRIMARY KEY  CLUSTERED ([discountID] ASC,[pubID] ASC)
go


ALTER TABLE [CUSTDISC]
	ADD CONSTRAINT [R_15] FOREIGN KEY ([discountID],[pubID]) REFERENCES [DISCOUNT]([discountID],[pubID])
		ON DELETE CASCADE
		ON UPDATE CASCADE
go

ALTER TABLE [CUSTDISC]
	ADD CONSTRAINT [R_16] FOREIGN KEY ([storeID]) REFERENCES [STORE]([storeID])
		ON DELETE CASCADE
		ON UPDATE NO ACTION
go


ALTER TABLE [DISCOUNT]
	ADD CONSTRAINT [R_10] FOREIGN KEY ([pubID]) REFERENCES [PUBLISHER]([pubID])
		ON DELETE CASCADE
		ON UPDATE NO ACTION
go


ALTER TABLE [EMPLOYMENT]
	ADD CONSTRAINT [R_6] FOREIGN KEY ([jobID],[pubID]) REFERENCES [JOB]([jobID],[pubID])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [EMPLOYMENT]
	ADD CONSTRAINT [R_5] FOREIGN KEY ([SSN]) REFERENCES [PERSON]([SSN])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [JOB]
	ADD CONSTRAINT [R_7] FOREIGN KEY ([pubID]) REFERENCES [PUBLISHER]([pubID])
		ON DELETE CASCADE
		ON UPDATE NO ACTION
go


ALTER TABLE [SALE]
	ADD CONSTRAINT [R_8] FOREIGN KEY ([titleID]) REFERENCES [TITLE]([titleID])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [SALE]
	ADD CONSTRAINT [R_9] FOREIGN KEY ([storeID]) REFERENCES [STORE]([storeID])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [SALEDISCOUNT]
	ADD CONSTRAINT [R_11] FOREIGN KEY ([discountID],[pubID]) REFERENCES [DISCOUNT]([discountID],[pubID])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [SALEDISCOUNT]
	ADD CONSTRAINT [R_12] FOREIGN KEY ([orderNO]) REFERENCES [SALE]([orderNO])
		ON DELETE CASCADE
		ON UPDATE NO ACTION
go


ALTER TABLE [TITLE]
	ADD CONSTRAINT [R_3] FOREIGN KEY ([pubID]) REFERENCES [PUBLISHER]([pubID])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [TITLEAUTHOR]
	ADD CONSTRAINT [R_1] FOREIGN KEY ([titleID]) REFERENCES [TITLE]([titleID])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE [TITLEAUTHOR]
	ADD CONSTRAINT [R_2] FOREIGN KEY ([authorID]) REFERENCES [AUTHOR]([authorID])
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go


ALTER TABLE [VOLUMEDISC]
	ADD CONSTRAINT [R_14] FOREIGN KEY ([discountID],[pubID]) REFERENCES [DISCOUNT]([discountID],[pubID])
		ON DELETE CASCADE
		ON UPDATE CASCADE
go


CREATE TRIGGER tD_AUTHOR ON AUTHOR FOR DELETE AS
/* erwin Builtin Trigger */
/* DELETE trigger on AUTHOR */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* erwin Builtin Trigger */
    /* AUTHOR  TITLEAUTHOR on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="000110f1", PARENT_OWNER="", PARENT_TABLE="AUTHOR"
    CHILD_OWNER="", CHILD_TABLE="TITLEAUTHOR"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_2", FK_COLUMNS="authorID" */
    IF EXISTS (
      SELECT * FROM deleted,TITLEAUTHOR
      WHERE
        /*  %JoinFKPK(TITLEAUTHOR,deleted," = "," AND") */
        TITLEAUTHOR.authorID = deleted.authorID
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete AUTHOR because TITLEAUTHOR exists.'
      GOTO error
    END


    /* erwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_AUTHOR ON AUTHOR FOR UPDATE AS
/* erwin Builtin Trigger */
/* UPDATE trigger on AUTHOR */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insauthorID char(18),
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* erwin Builtin Trigger */
  /* AUTHOR  TITLEAUTHOR on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="0001301a", PARENT_OWNER="", PARENT_TABLE="AUTHOR"
    CHILD_OWNER="", CHILD_TABLE="TITLEAUTHOR"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_2", FK_COLUMNS="authorID" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(authorID)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,TITLEAUTHOR
      WHERE
        /*  %JoinFKPK(TITLEAUTHOR,deleted," = "," AND") */
        TITLEAUTHOR.authorID = deleted.authorID
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update AUTHOR because TITLEAUTHOR exists.'
      GOTO error
    END
  END


  /* erwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_CUSTDISC ON CUSTDISC FOR DELETE AS
/* erwin Builtin Trigger */
/* DELETE trigger on CUSTDISC */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* erwin Builtin Trigger */
    /* STORE  CUSTDISC on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00028bd6", PARENT_OWNER="", PARENT_TABLE="STORE"
    CHILD_OWNER="", CHILD_TABLE="CUSTDISC"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_16", FK_COLUMNS="storeID" */
    IF EXISTS (SELECT * FROM deleted,STORE
      WHERE
        /* %JoinFKPK(deleted,STORE," = "," AND") */
        deleted.storeID = STORE.storeID AND
        NOT EXISTS (
          SELECT * FROM CUSTDISC
          WHERE
            /* %JoinFKPK(CUSTDISC,STORE," = "," AND") */
            CUSTDISC.storeID = STORE.storeID
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last CUSTDISC because STORE exists.'
      GOTO error
    END

    /* erwin Builtin Trigger */
    /* DISCOUNT  CUSTDISC on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="DISCOUNT"
    CHILD_OWNER="", CHILD_TABLE="CUSTDISC"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_15", FK_COLUMNS="discountID""pubID" */
    IF EXISTS (SELECT * FROM deleted,DISCOUNT
      WHERE
        /* %JoinFKPK(deleted,DISCOUNT," = "," AND") */
        deleted.discountID = DISCOUNT.discountID AND
        deleted.pubID = DISCOUNT.pubID AND
        NOT EXISTS (
          SELECT * FROM CUSTDISC
          WHERE
            /* %JoinFKPK(CUSTDISC,DISCOUNT," = "," AND") */
            CUSTDISC.discountID = DISCOUNT.discountID AND
            CUSTDISC.pubID = DISCOUNT.pubID
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last CUSTDISC because DISCOUNT exists.'
      GOTO error
    END


    /* erwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_CUSTDISC ON CUSTDISC FOR UPDATE AS
/* erwin Builtin Trigger */
/* UPDATE trigger on CUSTDISC */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insdiscountID char(18), 
           @inspubID char(18),
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* erwin Builtin Trigger */
  /* STORE  CUSTDISC on child update no action */
  /* ERWIN_RELATION:CHECKSUM="0002b59b", PARENT_OWNER="", PARENT_TABLE="STORE"
    CHILD_OWNER="", CHILD_TABLE="CUSTDISC"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_16", FK_COLUMNS="storeID" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(storeID)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,STORE
        WHERE
          /* %JoinFKPK(inserted,STORE) */
          inserted.storeID = STORE.storeID
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update CUSTDISC because STORE does not exist.'
      GOTO error
    END
  END

  /* erwin Builtin Trigger */
  /* DISCOUNT  CUSTDISC on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="DISCOUNT"
    CHILD_OWNER="", CHILD_TABLE="CUSTDISC"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_15", FK_COLUMNS="discountID""pubID" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(discountID) OR
    UPDATE(pubID)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,DISCOUNT
        WHERE
          /* %JoinFKPK(inserted,DISCOUNT) */
          inserted.discountID = DISCOUNT.discountID and
          inserted.pubID = DISCOUNT.pubID
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update CUSTDISC because DISCOUNT does not exist.'
      GOTO error
    END
  END


  /* erwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_DISCOUNT ON DISCOUNT FOR DELETE AS
/* erwin Builtin Trigger */
/* DELETE trigger on DISCOUNT */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* erwin Builtin Trigger */
    /* DISCOUNT  CUSTDISC on parent delete cascade */
    /* ERWIN_RELATION:CHECKSUM="0003f0a0", PARENT_OWNER="", PARENT_TABLE="DISCOUNT"
    CHILD_OWNER="", CHILD_TABLE="CUSTDISC"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_15", FK_COLUMNS="discountID""pubID" */
    DELETE CUSTDISC
      FROM CUSTDISC,deleted
      WHERE
        /*  %JoinFKPK(CUSTDISC,deleted," = "," AND") */
        CUSTDISC.discountID = deleted.discountID AND
        CUSTDISC.pubID = deleted.pubID

    /* erwin Builtin Trigger */
    /* DISCOUNT  VOLUMEDISC on parent delete cascade */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="DISCOUNT"
    CHILD_OWNER="", CHILD_TABLE="VOLUMEDISC"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_14", FK_COLUMNS="discountID""pubID" */
    DELETE VOLUMEDISC
      FROM VOLUMEDISC,deleted
      WHERE
        /*  %JoinFKPK(VOLUMEDISC,deleted," = "," AND") */
        VOLUMEDISC.discountID = deleted.discountID AND
        VOLUMEDISC.pubID = deleted.pubID

    /* erwin Builtin Trigger */
    /* DISCOUNT  SALEDISCOUNT on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="DISCOUNT"
    CHILD_OWNER="", CHILD_TABLE="SALEDISCOUNT"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_11", FK_COLUMNS="discountID""pubID" */
    IF EXISTS (
      SELECT * FROM deleted,SALEDISCOUNT
      WHERE
        /*  %JoinFKPK(SALEDISCOUNT,deleted," = "," AND") */
        SALEDISCOUNT.discountID = deleted.discountID AND
        SALEDISCOUNT.pubID = deleted.pubID
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete DISCOUNT because SALEDISCOUNT exists.'
      GOTO error
    END

    /* erwin Builtin Trigger */
    /* PUBLISHER  DISCOUNT on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="PUBLISHER"
    CHILD_OWNER="", CHILD_TABLE="DISCOUNT"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_10", FK_COLUMNS="pubID" */
    IF EXISTS (SELECT * FROM deleted,PUBLISHER
      WHERE
        /* %JoinFKPK(deleted,PUBLISHER," = "," AND") */
        deleted.pubID = PUBLISHER.pubID AND
        NOT EXISTS (
          SELECT * FROM DISCOUNT
          WHERE
            /* %JoinFKPK(DISCOUNT,PUBLISHER," = "," AND") */
            DISCOUNT.pubID = PUBLISHER.pubID
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last DISCOUNT because PUBLISHER exists.'
      GOTO error
    END


    /* erwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_DISCOUNT ON DISCOUNT FOR UPDATE AS
/* erwin Builtin Trigger */
/* UPDATE trigger on DISCOUNT */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insdiscountID char(18), 
           @inspubID char(18),
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* erwin Builtin Trigger */
  /* DISCOUNT  CUSTDISC on parent update cascade */
  /* ERWIN_RELATION:CHECKSUM="0005a298", PARENT_OWNER="", PARENT_TABLE="DISCOUNT"
    CHILD_OWNER="", CHILD_TABLE="CUSTDISC"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_15", FK_COLUMNS="discountID""pubID" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(discountID) OR
    UPDATE(pubID)
  BEGIN
    IF @numrows = 1
    BEGIN
      SELECT @insdiscountID = inserted.discountID, 
             @inspubID = inserted.pubID
        FROM inserted
      UPDATE CUSTDISC
      SET
        /*  %JoinFKPK(CUSTDISC,@ins," = ",",") */
        CUSTDISC.discountID = @insdiscountID,
        CUSTDISC.pubID = @inspubID
      FROM CUSTDISC,inserted,deleted
      WHERE
        /*  %JoinFKPK(CUSTDISC,deleted," = "," AND") */
        CUSTDISC.discountID = deleted.discountID AND
        CUSTDISC.pubID = deleted.pubID
    END
    ELSE
    BEGIN
      SELECT @errno = 30006,
             @errmsg = 'Cannot cascade DISCOUNT update because more than one row has been affected.'
      GOTO error
    END
  END

  /* erwin Builtin Trigger */
  /* DISCOUNT  VOLUMEDISC on parent update cascade */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="DISCOUNT"
    CHILD_OWNER="", CHILD_TABLE="VOLUMEDISC"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_14", FK_COLUMNS="discountID""pubID" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(discountID) OR
    UPDATE(pubID)
  BEGIN
    IF @numrows = 1
    BEGIN
      SELECT @insdiscountID = inserted.discountID, 
             @inspubID = inserted.pubID
        FROM inserted
      UPDATE VOLUMEDISC
      SET
        /*  %JoinFKPK(VOLUMEDISC,@ins," = ",",") */
        VOLUMEDISC.discountID = @insdiscountID,
        VOLUMEDISC.pubID = @inspubID
      FROM VOLUMEDISC,inserted,deleted
      WHERE
        /*  %JoinFKPK(VOLUMEDISC,deleted," = "," AND") */
        VOLUMEDISC.discountID = deleted.discountID AND
        VOLUMEDISC.pubID = deleted.pubID
    END
    ELSE
    BEGIN
      SELECT @errno = 30006,
             @errmsg = 'Cannot cascade DISCOUNT update because more than one row has been affected.'
      GOTO error
    END
  END

  /* erwin Builtin Trigger */
  /* DISCOUNT  SALEDISCOUNT on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="DISCOUNT"
    CHILD_OWNER="", CHILD_TABLE="SALEDISCOUNT"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_11", FK_COLUMNS="discountID""pubID" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(discountID) OR
    UPDATE(pubID)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,SALEDISCOUNT
      WHERE
        /*  %JoinFKPK(SALEDISCOUNT,deleted," = "," AND") */
        SALEDISCOUNT.discountID = deleted.discountID AND
        SALEDISCOUNT.pubID = deleted.pubID
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update DISCOUNT because SALEDISCOUNT exists.'
      GOTO error
    END
  END

  /* erwin Builtin Trigger */
  /* PUBLISHER  DISCOUNT on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="PUBLISHER"
    CHILD_OWNER="", CHILD_TABLE="DISCOUNT"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_10", FK_COLUMNS="pubID" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(pubID)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,PUBLISHER
        WHERE
          /* %JoinFKPK(inserted,PUBLISHER) */
          inserted.pubID = PUBLISHER.pubID
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update DISCOUNT because PUBLISHER does not exist.'
      GOTO error
    END
  END


  /* erwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_EMPLOYMENT ON EMPLOYMENT FOR DELETE AS
/* erwin Builtin Trigger */
/* DELETE trigger on EMPLOYMENT */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* erwin Builtin Trigger */
    /* JOB  EMPLOYMENT on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="0002605b", PARENT_OWNER="", PARENT_TABLE="JOB"
    CHILD_OWNER="", CHILD_TABLE="EMPLOYMENT"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_6", FK_COLUMNS="jobID""pubID" */
    IF EXISTS (SELECT * FROM deleted,JOB
      WHERE
        /* %JoinFKPK(deleted,JOB," = "," AND") */
        deleted.jobID = JOB.jobID AND
        deleted.pubID = JOB.pubID AND
        NOT EXISTS (
          SELECT * FROM EMPLOYMENT
          WHERE
            /* %JoinFKPK(EMPLOYMENT,JOB," = "," AND") */
            EMPLOYMENT.jobID = JOB.jobID AND
            EMPLOYMENT.pubID = JOB.pubID
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last EMPLOYMENT because JOB exists.'
      GOTO error
    END

    /* erwin Builtin Trigger */
    /* PERSON  EMPLOYMENT on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="PERSON"
    CHILD_OWNER="", CHILD_TABLE="EMPLOYMENT"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_5", FK_COLUMNS="SSN" */
    IF EXISTS (SELECT * FROM deleted,PERSON
      WHERE
        /* %JoinFKPK(deleted,PERSON," = "," AND") */
        deleted.SSN = PERSON.SSN AND
        NOT EXISTS (
          SELECT * FROM EMPLOYMENT
          WHERE
            /* %JoinFKPK(EMPLOYMENT,PERSON," = "," AND") */
            EMPLOYMENT.SSN = PERSON.SSN
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last EMPLOYMENT because PERSON exists.'
      GOTO error
    END


    /* erwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_EMPLOYMENT ON EMPLOYMENT FOR UPDATE AS
/* erwin Builtin Trigger */
/* UPDATE trigger on EMPLOYMENT */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insSSN char(18), 
           @insjobID char(18), 
           @inspubID char(18),
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* erwin Builtin Trigger */
  /* JOB  EMPLOYMENT on child update no action */
  /* ERWIN_RELATION:CHECKSUM="0002a4ef", PARENT_OWNER="", PARENT_TABLE="JOB"
    CHILD_OWNER="", CHILD_TABLE="EMPLOYMENT"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_6", FK_COLUMNS="jobID""pubID" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(jobID) OR
    UPDATE(pubID)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,JOB
        WHERE
          /* %JoinFKPK(inserted,JOB) */
          inserted.jobID = JOB.jobID and
          inserted.pubID = JOB.pubID
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update EMPLOYMENT because JOB does not exist.'
      GOTO error
    END
  END

  /* erwin Builtin Trigger */
  /* PERSON  EMPLOYMENT on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="PERSON"
    CHILD_OWNER="", CHILD_TABLE="EMPLOYMENT"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_5", FK_COLUMNS="SSN" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(SSN)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,PERSON
        WHERE
          /* %JoinFKPK(inserted,PERSON) */
          inserted.SSN = PERSON.SSN
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update EMPLOYMENT because PERSON does not exist.'
      GOTO error
    END
  END


  /* erwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_JOB ON JOB FOR DELETE AS
/* erwin Builtin Trigger */
/* DELETE trigger on JOB */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* erwin Builtin Trigger */
    /* JOB  EMPLOYMENT on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00023097", PARENT_OWNER="", PARENT_TABLE="JOB"
    CHILD_OWNER="", CHILD_TABLE="EMPLOYMENT"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_6", FK_COLUMNS="jobID""pubID" */
    IF EXISTS (
      SELECT * FROM deleted,EMPLOYMENT
      WHERE
        /*  %JoinFKPK(EMPLOYMENT,deleted," = "," AND") */
        EMPLOYMENT.jobID = deleted.jobID AND
        EMPLOYMENT.pubID = deleted.pubID
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete JOB because EMPLOYMENT exists.'
      GOTO error
    END

    /* erwin Builtin Trigger */
    /* PUBLISHER  JOB on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="PUBLISHER"
    CHILD_OWNER="", CHILD_TABLE="JOB"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_7", FK_COLUMNS="pubID" */
    IF EXISTS (SELECT * FROM deleted,PUBLISHER
      WHERE
        /* %JoinFKPK(deleted,PUBLISHER," = "," AND") */
        deleted.pubID = PUBLISHER.pubID AND
        NOT EXISTS (
          SELECT * FROM JOB
          WHERE
            /* %JoinFKPK(JOB,PUBLISHER," = "," AND") */
            JOB.pubID = PUBLISHER.pubID
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last JOB because PUBLISHER exists.'
      GOTO error
    END


    /* erwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_JOB ON JOB FOR UPDATE AS
/* erwin Builtin Trigger */
/* UPDATE trigger on JOB */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insjobID char(18), 
           @inspubID char(18),
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* erwin Builtin Trigger */
  /* JOB  EMPLOYMENT on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00027cff", PARENT_OWNER="", PARENT_TABLE="JOB"
    CHILD_OWNER="", CHILD_TABLE="EMPLOYMENT"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_6", FK_COLUMNS="jobID""pubID" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(jobID) OR
    UPDATE(pubID)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,EMPLOYMENT
      WHERE
        /*  %JoinFKPK(EMPLOYMENT,deleted," = "," AND") */
        EMPLOYMENT.jobID = deleted.jobID AND
        EMPLOYMENT.pubID = deleted.pubID
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update JOB because EMPLOYMENT exists.'
      GOTO error
    END
  END

  /* erwin Builtin Trigger */
  /* PUBLISHER  JOB on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="PUBLISHER"
    CHILD_OWNER="", CHILD_TABLE="JOB"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_7", FK_COLUMNS="pubID" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(pubID)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,PUBLISHER
        WHERE
          /* %JoinFKPK(inserted,PUBLISHER) */
          inserted.pubID = PUBLISHER.pubID
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update JOB because PUBLISHER does not exist.'
      GOTO error
    END
  END


  /* erwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_PERSON ON PERSON FOR DELETE AS
/* erwin Builtin Trigger */
/* DELETE trigger on PERSON */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* erwin Builtin Trigger */
    /* PERSON  EMPLOYMENT on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="0000fdd5", PARENT_OWNER="", PARENT_TABLE="PERSON"
    CHILD_OWNER="", CHILD_TABLE="EMPLOYMENT"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_5", FK_COLUMNS="SSN" */
    IF EXISTS (
      SELECT * FROM deleted,EMPLOYMENT
      WHERE
        /*  %JoinFKPK(EMPLOYMENT,deleted," = "," AND") */
        EMPLOYMENT.SSN = deleted.SSN
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete PERSON because EMPLOYMENT exists.'
      GOTO error
    END


    /* erwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_PERSON ON PERSON FOR UPDATE AS
/* erwin Builtin Trigger */
/* UPDATE trigger on PERSON */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insSSN char(18),
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* erwin Builtin Trigger */
  /* PERSON  EMPLOYMENT on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="000122aa", PARENT_OWNER="", PARENT_TABLE="PERSON"
    CHILD_OWNER="", CHILD_TABLE="EMPLOYMENT"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_5", FK_COLUMNS="SSN" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(SSN)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,EMPLOYMENT
      WHERE
        /*  %JoinFKPK(EMPLOYMENT,deleted," = "," AND") */
        EMPLOYMENT.SSN = deleted.SSN
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update PERSON because EMPLOYMENT exists.'
      GOTO error
    END
  END


  /* erwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_PUBLISHER ON PUBLISHER FOR DELETE AS
/* erwin Builtin Trigger */
/* DELETE trigger on PUBLISHER */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* erwin Builtin Trigger */
    /* PUBLISHER  DISCOUNT on parent delete cascade */
    /* ERWIN_RELATION:CHECKSUM="00025178", PARENT_OWNER="", PARENT_TABLE="PUBLISHER"
    CHILD_OWNER="", CHILD_TABLE="DISCOUNT"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_10", FK_COLUMNS="pubID" */
    DELETE DISCOUNT
      FROM DISCOUNT,deleted
      WHERE
        /*  %JoinFKPK(DISCOUNT,deleted," = "," AND") */
        DISCOUNT.pubID = deleted.pubID

    /* erwin Builtin Trigger */
    /* PUBLISHER  JOB on parent delete cascade */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="PUBLISHER"
    CHILD_OWNER="", CHILD_TABLE="JOB"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_7", FK_COLUMNS="pubID" */
    DELETE JOB
      FROM JOB,deleted
      WHERE
        /*  %JoinFKPK(JOB,deleted," = "," AND") */
        JOB.pubID = deleted.pubID

    /* erwin Builtin Trigger */
    /* PUBLISHER  TITLE on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="PUBLISHER"
    CHILD_OWNER="", CHILD_TABLE="TITLE"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_3", FK_COLUMNS="pubID" */
    IF EXISTS (
      SELECT * FROM deleted,TITLE
      WHERE
        /*  %JoinFKPK(TITLE,deleted," = "," AND") */
        TITLE.pubID = deleted.pubID
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete PUBLISHER because TITLE exists.'
      GOTO error
    END


    /* erwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_PUBLISHER ON PUBLISHER FOR UPDATE AS
/* erwin Builtin Trigger */
/* UPDATE trigger on PUBLISHER */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @inspubID char(18),
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* erwin Builtin Trigger */
  /* PUBLISHER  DISCOUNT on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="0002f68e", PARENT_OWNER="", PARENT_TABLE="PUBLISHER"
    CHILD_OWNER="", CHILD_TABLE="DISCOUNT"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_10", FK_COLUMNS="pubID" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(pubID)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,DISCOUNT
      WHERE
        /*  %JoinFKPK(DISCOUNT,deleted," = "," AND") */
        DISCOUNT.pubID = deleted.pubID
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update PUBLISHER because DISCOUNT exists.'
      GOTO error
    END
  END

  /* erwin Builtin Trigger */
  /* PUBLISHER  JOB on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="PUBLISHER"
    CHILD_OWNER="", CHILD_TABLE="JOB"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_7", FK_COLUMNS="pubID" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(pubID)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,JOB
      WHERE
        /*  %JoinFKPK(JOB,deleted," = "," AND") */
        JOB.pubID = deleted.pubID
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update PUBLISHER because JOB exists.'
      GOTO error
    END
  END

  /* erwin Builtin Trigger */
  /* PUBLISHER  TITLE on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="PUBLISHER"
    CHILD_OWNER="", CHILD_TABLE="TITLE"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_3", FK_COLUMNS="pubID" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(pubID)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,TITLE
      WHERE
        /*  %JoinFKPK(TITLE,deleted," = "," AND") */
        TITLE.pubID = deleted.pubID
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update PUBLISHER because TITLE exists.'
      GOTO error
    END
  END


  /* erwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_SALE ON SALE FOR DELETE AS
/* erwin Builtin Trigger */
/* DELETE trigger on SALE */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* erwin Builtin Trigger */
    /* SALE  SALEDISCOUNT on parent delete cascade */
    /* ERWIN_RELATION:CHECKSUM="0002ed7b", PARENT_OWNER="", PARENT_TABLE="SALE"
    CHILD_OWNER="", CHILD_TABLE="SALEDISCOUNT"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_12", FK_COLUMNS="orderNO" */
    DELETE SALEDISCOUNT
      FROM SALEDISCOUNT,deleted
      WHERE
        /*  %JoinFKPK(SALEDISCOUNT,deleted," = "," AND") */
        SALEDISCOUNT.orderNO = deleted.orderNO

    /* erwin Builtin Trigger */
    /* STORE  SALE on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="STORE"
    CHILD_OWNER="", CHILD_TABLE="SALE"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_9", FK_COLUMNS="storeID" */
    IF EXISTS (SELECT * FROM deleted,STORE
      WHERE
        /* %JoinFKPK(deleted,STORE," = "," AND") */
        deleted.storeID = STORE.storeID AND
        NOT EXISTS (
          SELECT * FROM SALE
          WHERE
            /* %JoinFKPK(SALE,STORE," = "," AND") */
            SALE.storeID = STORE.storeID
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last SALE because STORE exists.'
      GOTO error
    END

    /* erwin Builtin Trigger */
    /* TITLE  SALE on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="TITLE"
    CHILD_OWNER="", CHILD_TABLE="SALE"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_8", FK_COLUMNS="titleID" */
    IF EXISTS (SELECT * FROM deleted,TITLE
      WHERE
        /* %JoinFKPK(deleted,TITLE," = "," AND") */
        deleted.titleID = TITLE.titleID AND
        NOT EXISTS (
          SELECT * FROM SALE
          WHERE
            /* %JoinFKPK(SALE,TITLE," = "," AND") */
            SALE.titleID = TITLE.titleID
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last SALE because TITLE exists.'
      GOTO error
    END


    /* erwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_SALE ON SALE FOR UPDATE AS
/* erwin Builtin Trigger */
/* UPDATE trigger on SALE */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insorderNO char(18),
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* erwin Builtin Trigger */
  /* SALE  SALEDISCOUNT on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00038df2", PARENT_OWNER="", PARENT_TABLE="SALE"
    CHILD_OWNER="", CHILD_TABLE="SALEDISCOUNT"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_12", FK_COLUMNS="orderNO" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(orderNO)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,SALEDISCOUNT
      WHERE
        /*  %JoinFKPK(SALEDISCOUNT,deleted," = "," AND") */
        SALEDISCOUNT.orderNO = deleted.orderNO
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update SALE because SALEDISCOUNT exists.'
      GOTO error
    END
  END

  /* erwin Builtin Trigger */
  /* STORE  SALE on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="STORE"
    CHILD_OWNER="", CHILD_TABLE="SALE"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_9", FK_COLUMNS="storeID" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(storeID)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,STORE
        WHERE
          /* %JoinFKPK(inserted,STORE) */
          inserted.storeID = STORE.storeID
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update SALE because STORE does not exist.'
      GOTO error
    END
  END

  /* erwin Builtin Trigger */
  /* TITLE  SALE on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="TITLE"
    CHILD_OWNER="", CHILD_TABLE="SALE"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_8", FK_COLUMNS="titleID" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(titleID)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,TITLE
        WHERE
          /* %JoinFKPK(inserted,TITLE) */
          inserted.titleID = TITLE.titleID
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update SALE because TITLE does not exist.'
      GOTO error
    END
  END


  /* erwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_SALEDISCOUNT ON SALEDISCOUNT FOR DELETE AS
/* erwin Builtin Trigger */
/* DELETE trigger on SALEDISCOUNT */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* erwin Builtin Trigger */
    /* SALE  SALEDISCOUNT on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00028925", PARENT_OWNER="", PARENT_TABLE="SALE"
    CHILD_OWNER="", CHILD_TABLE="SALEDISCOUNT"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_12", FK_COLUMNS="orderNO" */
    IF EXISTS (SELECT * FROM deleted,SALE
      WHERE
        /* %JoinFKPK(deleted,SALE," = "," AND") */
        deleted.orderNO = SALE.orderNO AND
        NOT EXISTS (
          SELECT * FROM SALEDISCOUNT
          WHERE
            /* %JoinFKPK(SALEDISCOUNT,SALE," = "," AND") */
            SALEDISCOUNT.orderNO = SALE.orderNO
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last SALEDISCOUNT because SALE exists.'
      GOTO error
    END

    /* erwin Builtin Trigger */
    /* DISCOUNT  SALEDISCOUNT on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="DISCOUNT"
    CHILD_OWNER="", CHILD_TABLE="SALEDISCOUNT"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_11", FK_COLUMNS="discountID""pubID" */
    IF EXISTS (SELECT * FROM deleted,DISCOUNT
      WHERE
        /* %JoinFKPK(deleted,DISCOUNT," = "," AND") */
        deleted.discountID = DISCOUNT.discountID AND
        deleted.pubID = DISCOUNT.pubID AND
        NOT EXISTS (
          SELECT * FROM SALEDISCOUNT
          WHERE
            /* %JoinFKPK(SALEDISCOUNT,DISCOUNT," = "," AND") */
            SALEDISCOUNT.discountID = DISCOUNT.discountID AND
            SALEDISCOUNT.pubID = DISCOUNT.pubID
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last SALEDISCOUNT because DISCOUNT exists.'
      GOTO error
    END


    /* erwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_SALEDISCOUNT ON SALEDISCOUNT FOR UPDATE AS
/* erwin Builtin Trigger */
/* UPDATE trigger on SALEDISCOUNT */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insdiscountID char(18), 
           @insorderNO char(18), 
           @inspubID char(18),
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* erwin Builtin Trigger */
  /* SALE  SALEDISCOUNT on child update no action */
  /* ERWIN_RELATION:CHECKSUM="0002bb62", PARENT_OWNER="", PARENT_TABLE="SALE"
    CHILD_OWNER="", CHILD_TABLE="SALEDISCOUNT"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_12", FK_COLUMNS="orderNO" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(orderNO)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,SALE
        WHERE
          /* %JoinFKPK(inserted,SALE) */
          inserted.orderNO = SALE.orderNO
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update SALEDISCOUNT because SALE does not exist.'
      GOTO error
    END
  END

  /* erwin Builtin Trigger */
  /* DISCOUNT  SALEDISCOUNT on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="DISCOUNT"
    CHILD_OWNER="", CHILD_TABLE="SALEDISCOUNT"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_11", FK_COLUMNS="discountID""pubID" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(discountID) OR
    UPDATE(pubID)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,DISCOUNT
        WHERE
          /* %JoinFKPK(inserted,DISCOUNT) */
          inserted.discountID = DISCOUNT.discountID and
          inserted.pubID = DISCOUNT.pubID
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update SALEDISCOUNT because DISCOUNT does not exist.'
      GOTO error
    END
  END


  /* erwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_STORE ON STORE FOR DELETE AS
/* erwin Builtin Trigger */
/* DELETE trigger on STORE */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* erwin Builtin Trigger */
    /* STORE  CUSTDISC on parent delete cascade */
    /* ERWIN_RELATION:CHECKSUM="00019f3c", PARENT_OWNER="", PARENT_TABLE="STORE"
    CHILD_OWNER="", CHILD_TABLE="CUSTDISC"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_16", FK_COLUMNS="storeID" */
    DELETE CUSTDISC
      FROM CUSTDISC,deleted
      WHERE
        /*  %JoinFKPK(CUSTDISC,deleted," = "," AND") */
        CUSTDISC.storeID = deleted.storeID

    /* erwin Builtin Trigger */
    /* STORE  SALE on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="STORE"
    CHILD_OWNER="", CHILD_TABLE="SALE"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_9", FK_COLUMNS="storeID" */
    IF EXISTS (
      SELECT * FROM deleted,SALE
      WHERE
        /*  %JoinFKPK(SALE,deleted," = "," AND") */
        SALE.storeID = deleted.storeID
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete STORE because SALE exists.'
      GOTO error
    END


    /* erwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_STORE ON STORE FOR UPDATE AS
/* erwin Builtin Trigger */
/* UPDATE trigger on STORE */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insstoreID char(18),
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* erwin Builtin Trigger */
  /* STORE  CUSTDISC on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00021993", PARENT_OWNER="", PARENT_TABLE="STORE"
    CHILD_OWNER="", CHILD_TABLE="CUSTDISC"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_16", FK_COLUMNS="storeID" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(storeID)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,CUSTDISC
      WHERE
        /*  %JoinFKPK(CUSTDISC,deleted," = "," AND") */
        CUSTDISC.storeID = deleted.storeID
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update STORE because CUSTDISC exists.'
      GOTO error
    END
  END

  /* erwin Builtin Trigger */
  /* STORE  SALE on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="STORE"
    CHILD_OWNER="", CHILD_TABLE="SALE"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_9", FK_COLUMNS="storeID" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(storeID)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,SALE
      WHERE
        /*  %JoinFKPK(SALE,deleted," = "," AND") */
        SALE.storeID = deleted.storeID
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update STORE because SALE exists.'
      GOTO error
    END
  END


  /* erwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_TITLE ON TITLE FOR DELETE AS
/* erwin Builtin Trigger */
/* DELETE trigger on TITLE */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* erwin Builtin Trigger */
    /* TITLE  SALE on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="0002fd58", PARENT_OWNER="", PARENT_TABLE="TITLE"
    CHILD_OWNER="", CHILD_TABLE="SALE"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_8", FK_COLUMNS="titleID" */
    IF EXISTS (
      SELECT * FROM deleted,SALE
      WHERE
        /*  %JoinFKPK(SALE,deleted," = "," AND") */
        SALE.titleID = deleted.titleID
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete TITLE because SALE exists.'
      GOTO error
    END

    /* erwin Builtin Trigger */
    /* TITLE  TITLEAUTHOR on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="TITLE"
    CHILD_OWNER="", CHILD_TABLE="TITLEAUTHOR"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_1", FK_COLUMNS="titleID" */
    IF EXISTS (
      SELECT * FROM deleted,TITLEAUTHOR
      WHERE
        /*  %JoinFKPK(TITLEAUTHOR,deleted," = "," AND") */
        TITLEAUTHOR.titleID = deleted.titleID
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete TITLE because TITLEAUTHOR exists.'
      GOTO error
    END

    /* erwin Builtin Trigger */
    /* PUBLISHER  TITLE on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="PUBLISHER"
    CHILD_OWNER="", CHILD_TABLE="TITLE"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_3", FK_COLUMNS="pubID" */
    IF EXISTS (SELECT * FROM deleted,PUBLISHER
      WHERE
        /* %JoinFKPK(deleted,PUBLISHER," = "," AND") */
        deleted.pubID = PUBLISHER.pubID AND
        NOT EXISTS (
          SELECT * FROM TITLE
          WHERE
            /* %JoinFKPK(TITLE,PUBLISHER," = "," AND") */
            TITLE.pubID = PUBLISHER.pubID
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last TITLE because PUBLISHER exists.'
      GOTO error
    END


    /* erwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_TITLE ON TITLE FOR UPDATE AS
/* erwin Builtin Trigger */
/* UPDATE trigger on TITLE */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @institleID char(18),
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* erwin Builtin Trigger */
  /* TITLE  SALE on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00035624", PARENT_OWNER="", PARENT_TABLE="TITLE"
    CHILD_OWNER="", CHILD_TABLE="SALE"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_8", FK_COLUMNS="titleID" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(titleID)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,SALE
      WHERE
        /*  %JoinFKPK(SALE,deleted," = "," AND") */
        SALE.titleID = deleted.titleID
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update TITLE because SALE exists.'
      GOTO error
    END
  END

  /* erwin Builtin Trigger */
  /* TITLE  TITLEAUTHOR on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="TITLE"
    CHILD_OWNER="", CHILD_TABLE="TITLEAUTHOR"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_1", FK_COLUMNS="titleID" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(titleID)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,TITLEAUTHOR
      WHERE
        /*  %JoinFKPK(TITLEAUTHOR,deleted," = "," AND") */
        TITLEAUTHOR.titleID = deleted.titleID
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update TITLE because TITLEAUTHOR exists.'
      GOTO error
    END
  END

  /* erwin Builtin Trigger */
  /* PUBLISHER  TITLE on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="PUBLISHER"
    CHILD_OWNER="", CHILD_TABLE="TITLE"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_3", FK_COLUMNS="pubID" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(pubID)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,PUBLISHER
        WHERE
          /* %JoinFKPK(inserted,PUBLISHER) */
          inserted.pubID = PUBLISHER.pubID
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update TITLE because PUBLISHER does not exist.'
      GOTO error
    END
  END


  /* erwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_TITLEAUTHOR ON TITLEAUTHOR FOR DELETE AS
/* erwin Builtin Trigger */
/* DELETE trigger on TITLEAUTHOR */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* erwin Builtin Trigger */
    /* AUTHOR  TITLEAUTHOR on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="0002675b", PARENT_OWNER="", PARENT_TABLE="AUTHOR"
    CHILD_OWNER="", CHILD_TABLE="TITLEAUTHOR"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_2", FK_COLUMNS="authorID" */
    IF EXISTS (SELECT * FROM deleted,AUTHOR
      WHERE
        /* %JoinFKPK(deleted,AUTHOR," = "," AND") */
        deleted.authorID = AUTHOR.authorID AND
        NOT EXISTS (
          SELECT * FROM TITLEAUTHOR
          WHERE
            /* %JoinFKPK(TITLEAUTHOR,AUTHOR," = "," AND") */
            TITLEAUTHOR.authorID = AUTHOR.authorID
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last TITLEAUTHOR because AUTHOR exists.'
      GOTO error
    END

    /* erwin Builtin Trigger */
    /* TITLE  TITLEAUTHOR on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="TITLE"
    CHILD_OWNER="", CHILD_TABLE="TITLEAUTHOR"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_1", FK_COLUMNS="titleID" */
    IF EXISTS (SELECT * FROM deleted,TITLE
      WHERE
        /* %JoinFKPK(deleted,TITLE," = "," AND") */
        deleted.titleID = TITLE.titleID AND
        NOT EXISTS (
          SELECT * FROM TITLEAUTHOR
          WHERE
            /* %JoinFKPK(TITLEAUTHOR,TITLE," = "," AND") */
            TITLEAUTHOR.titleID = TITLE.titleID
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last TITLEAUTHOR because TITLE exists.'
      GOTO error
    END


    /* erwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_TITLEAUTHOR ON TITLEAUTHOR FOR UPDATE AS
/* erwin Builtin Trigger */
/* UPDATE trigger on TITLEAUTHOR */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @institleID char(18), 
           @insauthorID char(18),
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* erwin Builtin Trigger */
  /* AUTHOR  TITLEAUTHOR on child update no action */
  /* ERWIN_RELATION:CHECKSUM="0002a4af", PARENT_OWNER="", PARENT_TABLE="AUTHOR"
    CHILD_OWNER="", CHILD_TABLE="TITLEAUTHOR"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_2", FK_COLUMNS="authorID" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(authorID)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,AUTHOR
        WHERE
          /* %JoinFKPK(inserted,AUTHOR) */
          inserted.authorID = AUTHOR.authorID
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update TITLEAUTHOR because AUTHOR does not exist.'
      GOTO error
    END
  END

  /* erwin Builtin Trigger */
  /* TITLE  TITLEAUTHOR on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="TITLE"
    CHILD_OWNER="", CHILD_TABLE="TITLEAUTHOR"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_1", FK_COLUMNS="titleID" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(titleID)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,TITLE
        WHERE
          /* %JoinFKPK(inserted,TITLE) */
          inserted.titleID = TITLE.titleID
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update TITLEAUTHOR because TITLE does not exist.'
      GOTO error
    END
  END


  /* erwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go




CREATE TRIGGER tD_VOLUMEDISC ON VOLUMEDISC FOR DELETE AS
/* erwin Builtin Trigger */
/* DELETE trigger on VOLUMEDISC */
BEGIN
  DECLARE  @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)
    /* erwin Builtin Trigger */
    /* DISCOUNT  VOLUMEDISC on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00017629", PARENT_OWNER="", PARENT_TABLE="DISCOUNT"
    CHILD_OWNER="", CHILD_TABLE="VOLUMEDISC"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_14", FK_COLUMNS="discountID""pubID" */
    IF EXISTS (SELECT * FROM deleted,DISCOUNT
      WHERE
        /* %JoinFKPK(deleted,DISCOUNT," = "," AND") */
        deleted.discountID = DISCOUNT.discountID AND
        deleted.pubID = DISCOUNT.pubID AND
        NOT EXISTS (
          SELECT * FROM VOLUMEDISC
          WHERE
            /* %JoinFKPK(VOLUMEDISC,DISCOUNT," = "," AND") */
            VOLUMEDISC.discountID = DISCOUNT.discountID AND
            VOLUMEDISC.pubID = DISCOUNT.pubID
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last VOLUMEDISC because DISCOUNT exists.'
      GOTO error
    END


    /* erwin Builtin Trigger */
    RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

go


CREATE TRIGGER tU_VOLUMEDISC ON VOLUMEDISC FOR UPDATE AS
/* erwin Builtin Trigger */
/* UPDATE trigger on VOLUMEDISC */
BEGIN
  DECLARE  @numrows int,
           @nullcnt int,
           @validcnt int,
           @insdiscountID char(18), 
           @inspubID char(18),
           @errno   int,
           @severity int,
           @state    int,
           @errmsg  varchar(255)

  SELECT @numrows = @@rowcount
  /* erwin Builtin Trigger */
  /* DISCOUNT  VOLUMEDISC on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00017b18", PARENT_OWNER="", PARENT_TABLE="DISCOUNT"
    CHILD_OWNER="", CHILD_TABLE="VOLUMEDISC"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_14", FK_COLUMNS="discountID""pubID" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(discountID) OR
    UPDATE(pubID)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,DISCOUNT
        WHERE
          /* %JoinFKPK(inserted,DISCOUNT) */
          inserted.discountID = DISCOUNT.discountID and
          inserted.pubID = DISCOUNT.pubID
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    
    IF @validcnt + @nullcnt != @numrows
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update VOLUMEDISC because DISCOUNT does not exist.'
      GOTO error
    END
  END


  /* erwin Builtin Trigger */
  RETURN
error:
   RAISERROR (@errmsg, -- Message text.
              @severity, -- Severity (0~25).
              @state) -- State (0~255).
    rollback transaction
END

GO
use Group1Pubs

INSERT INTO AUTHOR (authorID, authorLName, authorFName, phone, address, city, state, zip, contract) VALUES
	('409-56-7008', 'Bennet', 'Abraham', '415 658-9932', '6223 Bateman St.', 'Berkeley', 'CA', '94705', 1),
	('213-46-8915', 'Green', 'Marjorie', '415 986-7020', '309 63rd St. #411', 'Oakland', 'CA', '94618', 1),
	('238-95-7766', 'Carson', 'Cheryl', '415 548-7723', '589 Darwin Ln.', 'Berkeley', 'CA', '94705', 1),
	('998-72-3567', 'Ringer', 'Albert', '801 826-0752', '67 Seventh Av.', 'Salt Lake City', 'UT', '84152', 1),
	('899-46-2035', 'Ringer', 'Anne', '801 826-0752', '67 Seventh Av.', 'Salt Lake City', 'UT', '84152', 1),
	('722-51-5454', 'DeFrance', 'Michel', '219 547-9982', '3 Balding Pl.', 'Gary', 'IN', '46403', 1),
	('807-91-6654', 'Panteley', 'Sylvia', '301 946-8853', '1956 Arlington Pl.', 'Rockville', 'MD', '20853', 1),
	('893-72-1158', 'McBadden', 'Heather','707 448-4982', '301 Putnam', 'Vacaville', 'CA', '95688', 0),
	('724-08-9931', 'Stringer', 'Dirk', '415 843-2991', '5420 Telegraph Av.', 'Oakland', 'CA', '94609', 0),
	('274-80-9391', 'Straight', 'Dean', '415 834-2919', '5420 College Av.', 'Oakland', 'CA', '94609', 1),
	('756-30-7391', 'Karsen', 'Livia', '415 534-9219', '5720 McAuley St.', 'Oakland', 'CA', '94609', 1),
	('724-80-9391', 'MacFeather', 'Stearns', '415 354-7128', '44 Upland Hts.', 'Oakland', 'CA', '94612', 1),
	('427-17-2319', 'Dull', 'Ann', '415 836-7128', '3410 Blonde St.', 'Palo Alto', 'CA', '94301', 1),
	('672-71-3249', 'Yokomoto', 'Akiko', '415 935-4228', '3 Silver Ct.', 'Walnut Creek', 'CA', '94595', 1),
	('267-41-2394', 'O''Leary', 'Michael', '408 286-2428', '22 Cleveland Av. #14', 'San Jose', 'CA', '95128', 1),
	('472-27-2349', 'Gringlesby', 'Burt', '707 938-6445', 'PO Box 792', 'Covelo', 'CA', '95428', 3),
	('527-72-3246', 'Greene', 'Morningstar', '615 297-2723', '22 Graybar House Rd.', 'Nashville', 'TN', '37215', 0),
	('172-32-1176', 'White', 'Johnson', '408 496-7223', '10932 Bigge Rd.', 'Menlo Park', 'CA', '94025', 1),
	('712-45-1867', 'del Castillo', 'Innes', '615 996-8275', '2286 Cram Pl. #86', 'Ann Arbor', 'MI', '48105', 1),
	('846-92-7186', 'Hunter', 'Sheryl', '415 836-7128', '3410 Blonde St.', 'Palo Alto', 'CA', '94301', 1),
	('486-29-1786', 'Locksley', 'Charlene', '415 585-4620', '18 Broadway Av.', 'San Francisco', 'CA', '94130', 1),
	('648-92-1872', 'Blotchet-Halls', 'Reginald', '503 745-6402', '55 Hillsdale Bl.', 'Corvallis', 'OR', '97330', 1),
	('341-22-1782', 'Smith', 'Meander', '913 843-0462', '10 Mississippi Dr.', 'Lawrence', 'KS', '66044', 0)
GO

INSERT INTO PUBLISHER (pubiD, pubName, city, state, country, logo, pr_info) VALUES
	('0736', 'New Moon Books', 'Boston', 'MA', 'USA', NULL, NULL),
	('0877', 'Binnet & Hardley', 'Washington', 'DC', 'USA', NULL, NULL),
	('1389', 'Algodata Infosystems', 'Berkeley', 'CA', 'USA', NULL, NULL),
	('9952', 'Scootney Books', 'New York', 'NY', 'USA', NULL, NULL),
	('1622', 'Five Lakes Publishing', 'Chicago', 'IL', 'USA', NULL, NULL),
	('1756', 'Ramona Publishers', 'Dallas', 'TX', 'USA', NULL, NULL),
	('9901', 'GGG&G', 'MÅnchen', NULL, 'Germany', NULL, NULL),
	('9999', 'Lucerne Publishing', 'Paris', NULL, 'France', NULL, NULL)
GO

INSERT INTO TITLE (titleID, title, type, pubID, price, advance, royalty, notes, pubdate) VALUES
	('PC8888', 'Secrets of Silicon Valley', 'popular_comp', 
	'1389', $20.00, 10, 4095,
	'Muckraking reporting on the world''s largest computer hardware and software manufacturers.',
	'06/12/94'),

	('BU1032', 'The Busy Executive''s Database Guide', 'business',
	'1389', $19.99, 10, 4095,
	'An overview of available database systems with emphasis on common business applications. Illustrated.',
	'06/12/91'),

	('PS7777', 'Emotional Security: A New Algorithm', 'psychology',
	'0736', $7.99, 10, 3336,
	'Protecting yourself and your loved ones from undue emotional stress in the modern world. Use of computer and nutritional aids emphasized.',
	'06/12/91'),

	('PS3333', 'Prolonged Data Deprivation: Four Case Studies',
	'psychology', '0736', $19.99, 10, 4072,
	'What happens when the data runs dry?  Searching evaluations of information-shortage effects.',
	'06/12/91'),

	('BU1111', 'Cooking with Computers: Surreptitious Balance Sheets',
	'business', '1389', $11.95, 10, 3876,
	'Helpful hints on how to use your electronic resources to the best advantage.',
	'06/09/91'),

	('MC2222', 'Silicon Valley Gastronomic Treats', 'mod_cook', '0877',
	$19.99, 12, 2032,
	'Favorite recipes for quick, easy, and elegant meals.',
	'06/09/91'),

	('TC7777', 'Sushi, Anyone?', 'trad_cook', '0877', $14.99,
	10, 4095,
	'Detailed instructions on how to make authentic Japanese sushi in your spare time.',
	'06/12/91'),

	('TC4203', 'Fifty Years in Buckingham Palace Kitchens', 'trad_cook',
	'0877', $11.95, 14, 15096,
	'More anecdotes from the Queen''s favorite cook describing life among English royalty. Recipes, techniques, tender vignettes.',
	'06/12/91'),

	('PC1035', 'But Is It User Friendly?', 'popular_comp', '1389',
	$22.95, 16, 8780,
	'A survey of software for the naive user, focusing on the ''friendliness'' of each.',
	'06/30/91'),

	('BU2075', 'You Can Combat Computer Stress!', 'business', '0736',
	$2.99, 24, 18722,
	'The latest medical and psychological techniques for living with the electronic office. Easy-to-understand explanations.',
	'06/30/91'),

	('PS2091', 'Is Anger the Enemy?', 'psychology', '0736', $10.95,
	12, 2045,
	'Carefully researched study of the effects of strong emotions on the body. Metabolic charts included.',
	'06/15/91'),

	('PS2106', 'Life Without Fear', 'psychology', '0736', $7.00,
	10, 111,
	'New exercise, meditation, and nutritional techniques that can reduce the shock of daily interactions. Popular audience. Sample menus included, exercise video available separately.',
	'10/05/91'),

	('MC3021', 'The Gourmet Microwave', 'mod_cook', '0877', $2.99,
	24, 22246,
	'Traditional French gourmet recipes adapted for modern microwave cooking.',
	'06/18/91'),

	('TC3218', 'Onions, Leeks, and Garlic: Cooking Secrets of the Mediterranean',
	'trad_cook', '0877', $20.95, 10, 375,
	'Profusely illustrated in color, this makes a wonderful gift book for a cuisine-oriented friend.',
	'10/21/91'),

	('BU7832', 'Straight Talk About Computers', 'business', '1389',
	$19.99, 10, 4095,
	'Annotated analysis of what computers can do for you: a no-hype guide for the critical user.',
	'06/22/91'),

	('PS1372', 'Computer Phobic AND Non-Phobic Individuals: Behavior Variations',
	'psychology', '0877', $21.59, 10, 375,
	'A must for the specialist, this book examines the difference between those who hate and fear computers and those who don''t.',
	'10/21/91')

INSERT INTO TITLE (titleID, title, type, pubID, notes) values('PC9999', 'Net Etiquette', 'popular_comp', '1389', 'A must-read for computer conferencing.')

INSERT INTO TITLE (titleID, title, pubID) values('MC3026', 'The Psychology of Computer Cooking', '0877')
GO

INSERT INTO TITLEAUTHOR (authorID, titleID, authorOrder, royaltyPer) VALUES
	('409-56-7008', 'BU1032', 1, 60),
	('486-29-1786', 'PS7777', 1, 100),
	('486-29-1786', 'PC9999', 1, 100),
	('712-45-1867', 'MC2222', 1, 100),
	('172-32-1176', 'PS3333', 1, 100),
	('213-46-8915', 'BU1032', 2, 40),
	('238-95-7766', 'PC1035', 1, 100),
	('213-46-8915', 'BU2075', 1, 100),
	('998-72-3567', 'PS2091', 1, 50),
	('899-46-2035', 'PS2091', 2, 50),
	('998-72-3567', 'PS2106', 1, 100),
	('722-51-5454', 'MC3021', 1, 75),
	('899-46-2035', 'MC3021', 2, 25),
	('807-91-6654', 'TC3218', 1, 100),
	('274-80-9391', 'BU7832', 1, 100),
	('427-17-2319', 'PC8888', 1, 50),
	('846-92-7186', 'PC8888', 2, 50),
	('756-30-7391', 'PS1372', 1, 75),
	('724-80-9391', 'PS1372', 2, 25),
	('724-80-9391', 'BU1111', 1, 60),
	('267-41-2394', 'BU1111', 2, 40),
	('672-71-3249', 'TC7777', 1, 40),
	('267-41-2394', 'TC7777', 2, 30),
	('472-27-2349', 'TC7777', 3, 30),
	('648-92-1872', 'TC4203', 1, 100)
GO

INSERT INTO STORE (storeID, storeName, address, city, state, zip) VALUES
	('7066','Barnum''s','567 Pasadena Ave.','Tustin','CA','92789'),
	('7067','News & Brews','577 First St.','Los Gatos','CA','96745'),
	('7131','Doc-U-Mat: Quality Laundry and Books', '24-A Avogadro Way','Remulade','WA','98014'),
	('8042','Bookbeat','679 Carson St.','Portland','OR','89076'),
	('6380','Eric the Read Books','788 Catamaugus Ave.', 'Seattle','WA','98056'),
	('7896','Fricative Bookshop','89 Madison St.','Fremont','CA','90019')
GO

INSERT INTO SALE (storeID, orderNO, orderDate, quantity, payterms, titleID) VALUES
	('7066', 'QA7442.3', '09/13/94', 75, 'ON invoice','PS2091'),
	('7067', 'D4482', '09/14/94', 10, 'Net 60','PS2091'),
	('7131', 'N914008', '09/14/94', 20, 'Net 30','PS2091'),
	('7131', 'N914014', '09/14/94', 25, 'Net 30','MC3021'),
	('8042', '423LL922', '09/14/94', 15, 'ON invoice','MC3021'),
	('8042', '423LL930', '09/14/94', 10, 'ON invoice','BU1032'),
	('6380', '722a', '09/13/94', 3, 'Net 60','PS2091'),
	('6380', '6871', '09/14/94', 5, 'Net 60','BU1032'),
	('8042','P723', '03/11/93', 25, 'Net 30', 'BU1111'),
	('7896','X999', '02/21/93', 35, 'ON invoice', 'BU2075'),
	('7896','QQ2299', '10/28/93', 15, 'Net 60', 'BU7832'),
	('7896','TQ456', '12/12/93', 10, 'Net 60', 'MC2222'),
	('8042','QA879.1', '5/22/93', 30, 'Net 30', 'PC1035'),
	('7066','A2976', '5/24/93', 50, 'Net 30', 'PC8888'),
	('7131','P3087a', '5/29/93', 20, 'Net 60', 'PS1372'),
	('7131','P3087b', '5/29/93', 25, 'Net 60', 'PS2106'),
	('7131','P3087c', '5/29/93', 15, 'Net 60', 'PS3333'),
	('7131','P3087d', '5/29/93', 25, 'Net 60', 'PS7777'),
	('7067','P2121', '6/15/92', 40, 'Net 30', 'TC3218'),
	('7067','P2122', '6/15/92', 20, 'Net 30', 'TC4203'),
	('7067','P2123', '6/15/92', 20, 'Net 30', 'TC7777')
GO

INSERT INTO JOB (jobDesc, min_lvl, max_lvl, pubID) VALUES
	('New Hire - Job not specified', 10, 10, '0736'),
	('Chief Executive Officer', 200, 250, '0877'),
	('Business Operations Manager', 175, 225, '1389'),
	('Chief Financial Officier', 175, 250, '9952'),
	('Publisher', 150, 250, '1622'),
	('Managing Editor', 140, 225, '1756'),
	('Marketing Manager', 120, 200, '9901'),
	('Public Relations Manager', 100, 175, '9999'),
	('Acquisitions Manager', 75, 175, '0736'),
	('Productions Manager', 75, 165, '0877'),
	('Operations Manager', 75, 150, '1389'),
	('Editor', 25, 100, '9952'),
	('Sales Representative', 25, 100, '1622'),
	('Designer', 25, 100, '1756')
GO

INSERT INTO PERSON (SSN, personFName, personMInit, personLName) VALUES
	('111111111', 'Philip', 'T', 'Cramer'),
	('111111112', 'Ann', 'M', 'Devon'),
	('111111113', 'Francisco', '', 'Chang'),
	('111111114', 'Laurence', 'A', 'Lebihan'),
	('111111115', 'Paul', 'X', 'Henriot'),
	('111111116', 'Sven', 'K', 'Ottlieb'),
	('111111117', 'Rita', 'B', 'Muller'),
	('111111118', 'Maria', 'J', 'Pontes'),
	('111111119', 'Janine', 'Y', 'Labrune'),
	('111111110', 'Carlos', 'F', 'Hernadez'),
	('111111121', 'Victoria', 'P', 'Ashworth'),
	('111111131', 'Lesley', '', 'Brown'),
	('111111141', 'Anabela', 'R', 'Domingues'),
	('111111151', 'Martine', '', 'Rance'),
	('111111161', 'Peter', 'H', 'Franken'),
	('111111171', 'Daniel', 'B', 'Tonini'),
	('111111181', 'Helen', '', 'Bennett'),
	('111111191', 'Paolo', 'M', 'Accorti'),
	('111111101', 'Elizabeth', 'N', 'Lincoln'),
	('111111211', 'Matti', 'G', 'Karttunen'),
	('111111311', 'Palle', 'D', 'Ibsen'),
	('111111411', 'Mary', 'M', 'Saveley'),
	('111111511', 'Gary', 'H', 'Thomas'),
	('111111611', 'Martin', 'F', 'Sommer'),
	('111111711', 'Roland', '', 'Mendel'),
	('111111811', 'Howard', 'A', 'Snyder'),
	('111111911', 'Timothy', 'P', 'O''Rourke'),
	('111111011', 'Karin', 'F', 'Josephs'),
	('111112111', 'Diego', 'W', 'Roel'),
	('111113111', 'Maria', '', 'Larsson'),
	('111114111', 'Paula', 'S', 'Parente'),
	('111115111', 'Margaret', 'A', 'Smith'),
	('111116111', 'Aria', '', 'Cruz'),
	('111117111', 'Miguel', 'A', 'Paolino'),
	('111118111', 'Yoshi', '', 'Latimer'),
	('111119111', 'Carine', 'G', 'Schmitt'),
	('111110111', 'Pedro', 'S', 'Afonso'),
	('111121111', 'Annette', '', 'Roulet'),
	('111131111', 'Helvetius', 'A', 'Nagy'),
	('111141111', 'Manuel', '', 'Pereira'),
	('111151111', 'Karla', 'J', 'Jablonski'),
	('111161111', 'Pirkko', 'O', 'Koskitalo'),
	('111171111', 'Patricia', 'C', 'McKenna')
GO

INSERT INTO EMPLOYMENT (jobID, job_lvl, pubID, positionStartDate, SSN) VALUES
	(2, 215, (SELECT pubID FROM JOB WHERE jobID = 2), '11/11/89', '111111111'),
	(3, 200, (SELECT pubID FROM JOB WHERE jobID = 3), '07/16/91', '111111112'),
	(4, 227, (SELECT pubID FROM JOB WHERE jobID = 4), '11/03/90', '111111113'),
	(5, 175, (SELECT pubID FROM JOB WHERE jobID = 5), '06/03/90', '111111114'),
	(5, 159, (SELECT pubID FROM JOB WHERE jobID = 5), '08/19/93', '111111115'),
	(5, 150, (SELECT pubID FROM JOB WHERE jobID = 5), '04/05/91', '111111116'),
	(5, 198, (SELECT pubID FROM JOB WHERE jobID = 5), '10/09/93', '111111117'),
	(5, 246, (SELECT pubID FROM JOB WHERE jobID = 5), '03/01/89', '111111118'),
	(5, 172, (SELECT pubID FROM JOB WHERE jobID = 5), '05/26/91', '111111119'),
	(5, 211, (SELECT pubID FROM JOB WHERE jobID = 5), '04/21/89', '111111110'),
	(6, 140, (SELECT pubID FROM JOB WHERE jobID = 6), '09/13/90', '111111121'),
	(7, 120, (SELECT pubID FROM JOB WHERE jobID = 7), '02/13/91', '111111131'),
	(8, 100, (SELECT pubID FROM JOB WHERE jobID = 8), '01/27/93', '111111141'),
	(9, 75,  (SELECT pubID FROM JOB WHERE jobID = 9), '02/05/92', '111111151'),
	(10, 75, (SELECT pubID FROM JOB WHERE jobID = 10), '05/17/92','111111161'),
	(11, 75, (SELECT pubID FROM JOB WHERE jobID = 11), '01/01/90','111111171'),
	(12, 35, (SELECT pubID FROM JOB WHERE jobID = 12), '09/21/89','111111181'),
	(13, 35, (SELECT pubID FROM JOB WHERE jobID = 13), '08/27/92','111111191'),
	(14, 35, (SELECT pubID FROM JOB WHERE jobID = 14), '07/24/90','111111101'),
	(6, 220, (SELECT pubID FROM JOB WHERE jobID = 6), '05/01/94', '111111211'),
	(7, 195, (SELECT pubID FROM JOB WHERE jobID = 7), '05/09/93', '111111311'),
	(8, 175, (SELECT pubID FROM JOB WHERE jobID = 8), '06/29/93', '111111411'),
	(9, 170, (SELECT pubID FROM JOB WHERE jobID = 9), '08/09/88', '111111511'),
	(10, 165, (SELECT pubID FROM JOB WHERE jobID = 10),'04/13/90','111111611'),
	(11, 150, (SELECT pubID FROM JOB WHERE jobID = 11),'09/05/91','111111711'),
	(12, 100, (SELECT pubID FROM JOB WHERE jobID = 12),'11/19/88','111111811'),
	(13, 100, (SELECT pubID FROM JOB WHERE jobID = 13),'06/19/88','111111911'),
	(14, 100, (SELECT pubID FROM JOB WHERE jobID = 14),'10/17/92','111111011'),
	(6, 192, (SELECT pubID FROM JOB WHERE jobID = 6), '12/16/91', '111112111'),
	(7, 135, (SELECT pubID FROM JOB WHERE jobID = 7), '03/27/92', '111113111'),
	(8, 125, (SELECT pubID FROM JOB WHERE jobID = 8), '01/19/94', '111114111'),
	(9, 78, (SELECT pubID FROM JOB WHERE jobID = 9), '09/29/88',  '111115111'),
	(10, 87, (SELECT pubID FROM JOB WHERE jobID = 10), '10/26/91','111116111'),
	(11, 112, (SELECT pubID FROM JOB WHERE jobID = 11),'12/07/92','111117111'),
	(12, 32, (SELECT pubID FROM JOB WHERE jobID = 12), '06/11/89','111118111'),
	(13, 64, (SELECT pubID FROM JOB WHERE jobID = 13),'07/07/92', '111119111'),
	(14, 89, (SELECT pubID FROM JOB WHERE jobID = 14),'12/24/90', '111110111'),
	(6, 152, (SELECT pubID FROM JOB WHERE jobID = 6), '02/21/90', '111121111'),
	(7, 120, (SELECT pubID FROM JOB WHERE jobID = 7), '03/19/93', '111131111'),
	(8, 101, (SELECT pubID FROM JOB WHERE jobID = 8), '01/09/89', '111141111'),
	(9, 170, (SELECT pubID FROM JOB WHERE jobID = 9), '03/11/94', '111151111'),
	(10, 80, (SELECT pubID FROM JOB WHERE jobID = 10),'11/29/93', '111161111'),
	(11, 150, (SELECT pubID FROM JOB WHERE jobID = 11),'08/01/89','111171111')
GO

INSERT INTO DISCOUNT (pubID, discountTypeDesc, discountAmount) VALUES
	('0736', 'VOLUME', 5.00),
	('0736', 'INITIALCUST', 10.50),
	('0736', 'CUST', 5.00),
	('0736', 'CUST', 7.00),
	('0736', 'CUST', 4.00),
	('0877', 'VOLUME', 7.00),
	('0877', 'INITIALCUST', 14.50),
	('0877', 'CUST', 7.00),
	('0877', 'CUST', 4.00),
	('1389', 'VOLUME', 10.00),
	('1389', 'INITIALCUST', 9.00),
	('1389', 'CUST', 6.50),
	('1389', 'CUST', 9.00),
	('1389', 'CUST', 8.00),	
	('1622', 'VOLUME', 3.50),
	('1622', 'INITIALCUST', 10.50),
	('1622', 'CUST', 5.00),
	('1622', 'CUST', 10.00),
	('1622', 'CUST', 4.00),	
	('1756', 'INITIALCUST', 11.00),
	('1756', 'CUST', 1.00),
	('1756', 'CUST', 2.00),
	('1756', 'CUST', 3.00),	
	('9901', 'VOLUME', 2.50),
	('9901', 'INITIALCUST', 12.75),
	('9901', 'CUST', 7.00),
	('9901', 'CUST', 7.00),
	('9901', 'CUST', 7.00),
	('9901', 'CUST', 8.00),	
	('9952', 'VOLUME', 5.00),
	('9952', 'CUST', 5.00),
	('9952', 'CUST', 6.00),
	('9952', 'CUST', 3.00),	
	('9999', 'VOLUME', 8.00),
	('9999', 'INITIALCUST', 4.50),
	('9999', 'CUST', 6.00),
	('9999', 'CUST', 2.00),
	('9999', 'CUST', 4.00)
GO

INSERT INTO CUSTDISC (pubID, storeID, discountID) VALUES
	('0736', 6380, 3),
	('0736', 7067, 4),
	('0736', 7066, 5),		
	('0877', 6380, 8),
	('0877', 8042, 9),	
	('1389', 7066, 12),
	('1389', 7131, 13),
	('1389', 6380, 14),		
	('1622', 7067, 17),
	('1622', 6380, 18),
	('1622', 7066, 19),
	('1756', 7131, 21),
	('1756', 7067, 22),		
	('1756', 6380, 23),
	('9901', 7131, 26),
	('9901', 8042, 27),
	('9901', 6380, 28),
	('9901', 7066, 29),	
	('9952', 7131, 31),
	('9952', 8042, 32),
	('9952', 7066, 33),
	('9999', 8042, 36),
	('9999', 6380, 37),	
	('9999', 6380, 38)
GO

INSERT INTO VOLUMEDISC (pubID, discountID, lowQty, highQty) VALUES
	('0736', 1, 100, 1000),
	('0877', 6, 150, 800),
	('1389', 10, 50, 1500),
	('1622', 15, 300, 2000),
	('9901', 24, 25, 250),
	('9952', 30, 75, 500),
	('9999', 34, 100, 750)
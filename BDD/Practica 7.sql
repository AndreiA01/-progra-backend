/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2016                    */
/* Created on:     16/11/2018 9:34:15                           */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('enlaces') and o.name = 'fk_enlaces_tiene_publicac')
alter table enlaces
   drop constraint fk_enlaces_tiene_publicac
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('enlaces') and o.name = 'fk_enlaces_tipo_tipo_enl')
alter table enlaces
   drop constraint fk_enlaces_tipo_tipo_enl
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('enlaces')
            and   name  = 'tipo_fk'
            and   indid > 0
            and   indid < 255)
   drop index enlaces.tipo_fk
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('enlaces')
            and   name  = 'relationship_1_fk'
            and   indid > 0
            and   indid < 255)
   drop index enlaces.relationship_1_fk
go

if exists (select 1
            from  sysobjects
           where  id = object_id('enlaces')
            and   type = 'U')
   drop table enlaces
go

if exists (select 1
            from  sysobjects
           where  id = object_id('publicaciones')
            and   type = 'U')
   drop table publicaciones
go

if exists (select 1
            from  sysobjects
           where  id = object_id('tipo_enlace')
            and   type = 'U')
   drop table tipo_enlace
go

/*==============================================================*/
/* Table: enlaces                                               */
/*==============================================================*/
create table enlaces (
   id_te                int                  not null,
   id_pu                bigint               not null,
   link_en              varchar(500)         not null,
   constraint pk_enlaces primary key nonclustered (id_te, id_pu)
)
go

/*==============================================================*/
/* Index: relationship_1_fk                                     */
/*==============================================================*/




create nonclustered index relationship_1_fk on enlaces (id_pu asc)
go

/*==============================================================*/
/* Index: tipo_fk                                               */
/*==============================================================*/




create nonclustered index tipo_fk on enlaces (id_te asc)
go

/*==============================================================*/
/* Table: publicaciones                                         */
/*==============================================================*/
create table publicaciones (
   id_pu                bigint               identity,
   autores_pu           varchar(500)         null,
   titulo_pu            varchar(500)         null,
   fecha_pu             timestamp            null,
   cita_pu              text                 null,
   constraint pk_publicaciones primary key (id_pu)
)
go

/*==============================================================*/
/* Table: tipo_enlace                                           */
/*==============================================================*/
create table tipo_enlace (
   id_te                int                  identity,
   titulo_te            varchar(20)          not null,
   constraint pk_tipo_enlace primary key (id_te)
)
go

alter table enlaces
   add constraint fk_enlaces_tiene_publicac foreign key (id_pu)
      references publicaciones (id_pu)
go

alter table enlaces
   add constraint fk_enlaces_tipo_tipo_enl foreign key (id_te)
      references tipo_enlace (id_te)
go


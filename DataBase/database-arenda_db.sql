-- Database generated with pgModeler (PostgreSQL Database Modeler).
-- pgModeler  version: 0.9.2
-- PostgreSQL version: 12.0
-- Project Site: pgmodeler.io
-- Model Author: ---


-- Database creation must be done outside a multicommand file.
-- These commands were put in this file only as a convenience.
-- -- object: arenda_db | type: DATABASE --
-- -- DROP DATABASE IF EXISTS arenda_db;
-- CREATE DATABASE arenda_db;
-- -- ddl-end --
-- 

-- object: public."точка" | type: TABLE --
-- DROP TABLE IF EXISTS public."точка" CASCADE;
CREATE TABLE public."точка" (
	floor int2 NOT NULL,
	square int2 NOT NULL,
	conditioner bool,
	price_day decimal NOT NULL,
	id serial NOT NULL,
	CONSTRAINT "точка_pk" PRIMARY KEY (id)

);
-- ddl-end --
-- ALTER TABLE public."точка" OWNER TO postgres;
-- ddl-end --





-- object: public."клиент" | type: TABLE --
-- DROP TABLE IF EXISTS public."клиент" CASCADE;
CREATE TABLE public."клиент" (
	name text NOT NULL,
	adress text,
	phone text NOT NULL,
	requisites text,
	contact_name text NOT NULL,
	id serial NOT NULL,
	CONSTRAINT "клиент_pk" PRIMARY KEY (id)

);
-- ddl-end --
-- ALTER TABLE public."клиент" OWNER TO postgres;
-- ddl-end --





-- object: public."договор" | type: TABLE --
-- DROP TABLE IF EXISTS public."договор" CASCADE;
CREATE TABLE public."договор" (
	end_rent date NOT NULL,
	"id_клиент" integer NOT NULL,
	id serial NOT NULL,
	begin_rent date,
	"id_точка" integer NOT NULL,
	CONSTRAINT "договор_pk" PRIMARY KEY (id)

);
-- ddl-end --
-- ALTER TABLE public."договор" OWNER TO postgres;
-- ddl-end --




-- object: "клиент_fk" | type: CONSTRAINT --
-- ALTER TABLE public."договор" DROP CONSTRAINT IF EXISTS "клиент_fk" CASCADE;
ALTER TABLE public."договор" ADD CONSTRAINT "клиент_fk" FOREIGN KEY ("id_клиент")
REFERENCES public."клиент" (id) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: "точка_fk" | type: CONSTRAINT --
-- ALTER TABLE public."договор" DROP CONSTRAINT IF EXISTS "точка_fk" CASCADE;
ALTER TABLE public."договор" ADD CONSTRAINT "точка_fk" FOREIGN KEY ("id_точка")
REFERENCES public."точка" (id) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --

-- object: public."оплата" | type: TABLE --
-- DROP TABLE IF EXISTS public."оплата" CASCADE;
CREATE TABLE public."оплата" (
	month decimal,
	year decimal,
	payment decimal,
	id serial NOT NULL,
	"id_договор" integer NOT NULL,
	CONSTRAINT "прайс_pk" PRIMARY KEY (id)

);
-- ddl-end --
-- ALTER TABLE public."оплата" OWNER TO postgres;
-- ddl-end --

-- object: "договор_fk" | type: CONSTRAINT --
-- ALTER TABLE public."оплата" DROP CONSTRAINT IF EXISTS "договор_fk" CASCADE;
ALTER TABLE public."оплата" ADD CONSTRAINT "договор_fk" FOREIGN KEY ("id_договор")
REFERENCES public."договор" (id) MATCH FULL
ON DELETE RESTRICT ON UPDATE CASCADE;
-- ddl-end --



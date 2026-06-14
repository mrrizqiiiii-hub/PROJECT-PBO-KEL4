
BEGIN;


CREATE TABLE IF NOT EXISTS public.customer
(
    id_customer serial NOT NULL,
    nama_customer character varying(150) COLLATE pg_catalog."default" NOT NULL,
    no_telpon character varying(20) COLLATE pg_catalog."default" NOT NULL,
    alamat character varying(200) COLLATE pg_catalog."default",
    CONSTRAINT customer_pkey PRIMARY KEY (id_customer)
);

CREATE TABLE IF NOT EXISTS public.detail_komoditas
(
    id_detail_komoditas serial NOT NULL,
    stok integer NOT NULL,
    harga numeric(15, 2) NOT NULL,
    status_aktif character(1) COLLATE pg_catalog."default" NOT NULL,
    id_user integer,
    id_komoditas integer,
    merk character varying(100) COLLATE pg_catalog."default" NOT NULL,
    deskripsi text COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT detail_komoditas_pkey PRIMARY KEY (id_detail_komoditas),
    CONSTRAINT dk_unique_merk UNIQUE (merk)
);

CREATE TABLE IF NOT EXISTS public.detail_transaksi
(
    id_detail_transaksi serial NOT NULL,
    kuantitas integer NOT NULL,
    id_detail_komoditas integer,
    id_transaksi integer,
    CONSTRAINT detail_transaksi_pkey PRIMARY KEY (id_detail_transaksi)
);

CREATE TABLE IF NOT EXISTS public.komoditas
(
    id_komoditas serial NOT NULL,
    maksimal_stok integer NOT NULL,
    maksimal_supplier integer NOT NULL,
    nama_komoditas character varying(100) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT komoditas_pkey PRIMARY KEY (id_komoditas)
);

CREATE TABLE IF NOT EXISTS public.pengajuan_komoditas
(
    id_pengajuan serial NOT NULL,
    merk character varying(100) COLLATE pg_catalog."default" NOT NULL,
    harga numeric(15, 2) NOT NULL,
    deskripsi text COLLATE pg_catalog."default",
    status_pengajuan character varying(50) COLLATE pg_catalog."default" NOT NULL,
    id_komoditas integer,
    id_user integer,
    CONSTRAINT pengajuan_komoditas_pkey PRIMARY KEY (id_pengajuan),
    CONSTRAINT pk_unique_merk UNIQUE (merk)
);

CREATE TABLE IF NOT EXISTS public.setoran
(
    id_setoran serial NOT NULL,
    tanggal_pengajuan date NOT NULL,
    jumlah_setoran integer NOT NULL,
    status_setoran character varying(50) COLLATE pg_catalog."default" NOT NULL,
    id_detail_komoditas integer,
    tanggal_selesai date,
    CONSTRAINT setoran_pkey PRIMARY KEY (id_setoran)
);

CREATE TABLE IF NOT EXISTS public.transaksi
(
    id_transaksi serial NOT NULL,
    tanggal_transaksi date NOT NULL,
    metode_pembayaran character varying(50) COLLATE pg_catalog."default" NOT NULL,
    id_customer integer,
    id_user integer,
    status_transaksi character varying(50) COLLATE pg_catalog."default" NOT NULL,
    total_harga numeric(15, 2) NOT NULL,
    CONSTRAINT transaksi_pkey PRIMARY KEY (id_transaksi)
);

CREATE TABLE IF NOT EXISTS public."user"
(
    id_user serial NOT NULL,
    email_user character varying(150) COLLATE pg_catalog."default",
    username_user character varying(50) COLLATE pg_catalog."default" NOT NULL,
    password_user character varying(150) COLLATE pg_catalog."default" NOT NULL,
    nama_lengkap character varying(150) COLLATE pg_catalog."default",
    no_telpon character varying(20) COLLATE pg_catalog."default",
    role character varying(50) COLLATE pg_catalog."default" NOT NULL,
    status_akun character varying(50) COLLATE pg_catalog."default" NOT NULL,
    alamat character varying(200) COLLATE pg_catalog."default",
    CONSTRAINT user_pkey PRIMARY KEY (id_user),
    CONSTRAINT user_email_user_key UNIQUE (email_user),
    CONSTRAINT user_username_user_key UNIQUE (username_user)
);

ALTER TABLE IF EXISTS public.detail_komoditas
    ADD CONSTRAINT detail_komoditas_id_komoditas_fkey FOREIGN KEY (id_komoditas)
    REFERENCES public.komoditas (id_komoditas) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE NO ACTION;


ALTER TABLE IF EXISTS public.detail_komoditas
    ADD CONSTRAINT detail_komoditas_id_user_fkey FOREIGN KEY (id_user)
    REFERENCES public."user" (id_user) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE NO ACTION;


ALTER TABLE IF EXISTS public.detail_transaksi
    ADD CONSTRAINT detail_transaksi_id_detail_komoditas_fkey FOREIGN KEY (id_detail_komoditas)
    REFERENCES public.detail_komoditas (id_detail_komoditas) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE NO ACTION;


ALTER TABLE IF EXISTS public.detail_transaksi
    ADD CONSTRAINT detail_transaksi_id_transaksi_fkey FOREIGN KEY (id_transaksi)
    REFERENCES public.transaksi (id_transaksi) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE NO ACTION;


ALTER TABLE IF EXISTS public.pengajuan_komoditas
    ADD CONSTRAINT pengajuan_komoditas_id_komoditas_fkey FOREIGN KEY (id_komoditas)
    REFERENCES public.komoditas (id_komoditas) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE NO ACTION;


ALTER TABLE IF EXISTS public.pengajuan_komoditas
    ADD CONSTRAINT pengajuan_komoditas_id_user_fkey FOREIGN KEY (id_user)
    REFERENCES public."user" (id_user) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE NO ACTION;


ALTER TABLE IF EXISTS public.setoran
    ADD CONSTRAINT setoran_id_detail_komoditas_fkey FOREIGN KEY (id_detail_komoditas)
    REFERENCES public.detail_komoditas (id_detail_komoditas) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE NO ACTION;


ALTER TABLE IF EXISTS public.transaksi
    ADD CONSTRAINT transaksi_id_customer_fkey FOREIGN KEY (id_customer)
    REFERENCES public.customer (id_customer) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE NO ACTION;


ALTER TABLE IF EXISTS public.transaksi
    ADD CONSTRAINT transaksi_id_user_fkey FOREIGN KEY (id_user)
    REFERENCES public."user" (id_user) MATCH SIMPLE
    ON UPDATE NO ACTION
    ON DELETE NO ACTION;
	
INSERT INTO "user" (username_user, password_user, "role", status_akun)
	VALUES ('Admin', 'admin123', 'Admin', 'Aktif');


END;
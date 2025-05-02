--
-- PostgreSQL database dump
--

-- Dumped from database version 17.4
-- Dumped by pg_dump version 17.4

-- Started on 2025-05-02 13:36:22

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 217 (class 1259 OID 16545)
-- Name: clientes; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.clientes (
    id_cliente integer NOT NULL,
    nombre_cliente character varying(60) NOT NULL,
    direccion_cliente character varying(60) NOT NULL,
    telefono_cliente character varying(10) NOT NULL
);


ALTER TABLE public.clientes OWNER TO postgres;

--
-- TOC entry 224 (class 1259 OID 16602)
-- Name: detalles; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.detalles (
    id_factura integer NOT NULL,
    id_item integer NOT NULL,
    cantidad integer NOT NULL,
    valor_unitario numeric(10,2) NOT NULL,
    CONSTRAINT detalles_cantidad_check CHECK ((cantidad >= 1))
);


ALTER TABLE public.detalles OWNER TO postgres;

--
-- TOC entry 225 (class 1259 OID 16618)
-- Name: devoluciones; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.devoluciones (
    id_factura integer NOT NULL,
    id_item integer NOT NULL,
    fecha_devolucion date NOT NULL,
    hora_devolucion time without time zone NOT NULL
);


ALTER TABLE public.devoluciones OWNER TO postgres;

--
-- TOC entry 218 (class 1259 OID 16550)
-- Name: empleados; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.empleados (
    id_empleado integer NOT NULL,
    nombre_empleado character varying(60) NOT NULL,
    telefono_empleado character varying(10) NOT NULL,
    cargo_empleado character varying(60) NOT NULL,
    salario_empleado numeric(10,2) NOT NULL,
    CONSTRAINT empleados_salario_empleado_check CHECK (((salario_empleado >= (1300000)::numeric) AND (salario_empleado <= (1500000)::numeric)))
);


ALTER TABLE public.empleados OWNER TO postgres;

--
-- TOC entry 223 (class 1259 OID 16587)
-- Name: facturas; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.facturas (
    id_factura integer NOT NULL,
    id_cliente integer NOT NULL,
    id_empleado integer NOT NULL,
    fecha_compra date NOT NULL,
    hora_compra time without time zone NOT NULL,
    valor_total_compra numeric(10,2) NOT NULL
);


ALTER TABLE public.facturas OWNER TO postgres;

--
-- TOC entry 220 (class 1259 OID 16561)
-- Name: items; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.items (
    id_item integer NOT NULL,
    nombre_item character varying(60) NOT NULL,
    pvp_item numeric(10,2) NOT NULL,
    porcentaje_iva_item numeric(5,2) NOT NULL
);


ALTER TABLE public.items OWNER TO postgres;

--
-- TOC entry 221 (class 1259 OID 16566)
-- Name: productos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.productos (
    id_producto integer NOT NULL,
    stock integer NOT NULL,
    id_item integer NOT NULL
);


ALTER TABLE public.productos OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 16556)
-- Name: proveedores; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.proveedores (
    id_proveedor integer NOT NULL,
    nombre_proveedor character varying(60) NOT NULL,
    direccion_proveedor character varying(60) NOT NULL,
    telefono_proveedor character varying(10) NOT NULL
);


ALTER TABLE public.proveedores OWNER TO postgres;

--
-- TOC entry 226 (class 1259 OID 16633)
-- Name: proveedores_productos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.proveedores_productos (
    id_proveedor integer NOT NULL,
    id_producto integer NOT NULL,
    valor_compra numeric(10,2) NOT NULL
);


ALTER TABLE public.proveedores_productos OWNER TO postgres;

--
-- TOC entry 222 (class 1259 OID 16576)
-- Name: servicios; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.servicios (
    id_servicio integer NOT NULL,
    categoria_servicio character varying(30) NOT NULL,
    id_item integer NOT NULL,
    CONSTRAINT servicios_categoria_servicio_check CHECK (((categoria_servicio)::text = ANY ((ARRAY['Internet'::character varying, 'Computación'::character varying, 'Corresponsalía'::character varying, 'Trabajo a mano'::character varying, 'Asesoría'::character varying])::text[])))
);


ALTER TABLE public.servicios OWNER TO postgres;

--
-- TOC entry 4908 (class 0 OID 16545)
-- Dependencies: 217
-- Data for Name: clientes; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.clientes (id_cliente, nombre_cliente, direccion_cliente, telefono_cliente) FROM stdin;
1	Laura Montoya	Calle 10 #20-30	3112345678
2	Pedro Suarez	Carrera 15 #5-10	3123456789
3	Sofia Restrepo	Avenida 30 #40-50	3134567890
4	Miguel Torres	Calle 50 #60-70	3145678901
5	Lucia Vargas	Carrera 70 #80-90	3156789012
6	Daniela Mora	Calle 100 #110-120	3167890123
7	Andres Castro	Carrera 120 #130-140	3178901234
8	Carolina Rios	Avenida 150 #160-170	3189012345
\.


--
-- TOC entry 4915 (class 0 OID 16602)
-- Dependencies: 224
-- Data for Name: detalles; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.detalles (id_factura, id_item, cantidad, valor_unitario) FROM stdin;
1	1	2	5000.00
2	2	5	800.00
3	3	3	500.00
4	4	4	1200.00
5	5	2	2500.00
6	6	6	700.00
7	7	7	3000.00
8	8	3	1500.00
\.


--
-- TOC entry 4916 (class 0 OID 16618)
-- Dependencies: 225
-- Data for Name: devoluciones; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.devoluciones (id_factura, id_item, fecha_devolucion, hora_devolucion) FROM stdin;
1	1	2024-05-10	10:30:00
2	2	2024-05-11	11:30:00
3	3	2024-05-12	12:30:00
4	4	2024-05-13	13:30:00
5	5	2024-05-14	14:30:00
6	6	2024-05-15	15:30:00
7	7	2024-05-16	16:30:00
8	8	2024-05-17	17:30:00
\.


--
-- TOC entry 4909 (class 0 OID 16550)
-- Dependencies: 218
-- Data for Name: empleados; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.empleados (id_empleado, nombre_empleado, telefono_empleado, cargo_empleado, salario_empleado) FROM stdin;
1	Juan Perez	3011234567	Cajero	1350000.00
2	Maria Lopez	3027654321	Vendedor	1400000.00
3	Carlos Mejia	3032345678	Supervisor	1450000.00
4	Ana Gonzalez	3048765432	Limpieza	1300000.00
5	Luis Ramirez	3053456789	Almacenista	1500000.00
\.


--
-- TOC entry 4914 (class 0 OID 16587)
-- Dependencies: 223
-- Data for Name: facturas; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.facturas (id_factura, id_cliente, id_empleado, fecha_compra, hora_compra, valor_total_compra) FROM stdin;
1	1	1	2024-05-01	10:00:00	10000.00
2	2	2	2024-05-02	11:00:00	5000.00
3	3	3	2024-05-03	12:00:00	7000.00
4	4	4	2024-05-04	13:00:00	3000.00
5	5	5	2024-05-05	14:00:00	8000.00
6	6	1	2024-05-06	15:00:00	6000.00
7	7	2	2024-05-07	16:00:00	9000.00
8	8	3	2024-05-08	17:00:00	4000.00
\.


--
-- TOC entry 4911 (class 0 OID 16561)
-- Dependencies: 220
-- Data for Name: items; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.items (id_item, nombre_item, pvp_item, porcentaje_iva_item) FROM stdin;
1	Cuaderno	5000.00	19.00
2	Lápiz	800.00	19.00
3	Borrador	500.00	19.00
4	Chocolatina	1200.00	19.00
5	Papas Fritas	2500.00	19.00
6	Sacapuntas	700.00	19.00
7	Resaltador	3000.00	19.00
8	Cartulina	1500.00	19.00
\.


--
-- TOC entry 4912 (class 0 OID 16566)
-- Dependencies: 221
-- Data for Name: productos; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.productos (id_producto, stock, id_item) FROM stdin;
1	100	1
2	200	2
3	150	3
4	300	4
5	250	5
6	180	6
7	120	7
8	90	8
\.


--
-- TOC entry 4910 (class 0 OID 16556)
-- Dependencies: 219
-- Data for Name: proveedores; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.proveedores (id_proveedor, nombre_proveedor, direccion_proveedor, telefono_proveedor) FROM stdin;
1	Papelería Central	Calle 20 #30-40	3201234567
2	Distribuidora Escolar	Carrera 25 #35-45	3212345678
3	Placita de dulces	Avenida 60 #70-80	3223456789
4	Papeles y Útiles	Calle 80 #90-100	3234567890
5	Artículos para Oficina	Carrera 45 #55-65	3245678901
6	Suministros Escolares	Avenida 100 #110-120	3256789012
7	Papelería La 15	Calle 15 #25-35	3267890123
8	Papelería El Estudiante	Carrera 50 #60-70	3278901234
\.


--
-- TOC entry 4917 (class 0 OID 16633)
-- Dependencies: 226
-- Data for Name: proveedores_productos; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.proveedores_productos (id_proveedor, id_producto, valor_compra) FROM stdin;
1	1	4500.00
2	2	750.00
3	3	450.00
4	4	1100.00
5	5	2300.00
6	6	650.00
7	7	2800.00
8	8	1400.00
\.


--
-- TOC entry 4913 (class 0 OID 16576)
-- Dependencies: 222
-- Data for Name: servicios; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.servicios (id_servicio, categoria_servicio, id_item) FROM stdin;
1	Internet	1
2	Computación	2
3	Corresponsalía	3
4	Trabajo a mano	4
5	Asesoría	5
6	Computación	6
7	Internet	7
8	Corresponsalía	8
\.


--
-- TOC entry 4734 (class 2606 OID 16549)
-- Name: clientes clientes_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.clientes
    ADD CONSTRAINT clientes_pkey PRIMARY KEY (id_cliente);


--
-- TOC entry 4748 (class 2606 OID 16607)
-- Name: detalles detalles_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detalles
    ADD CONSTRAINT detalles_pkey PRIMARY KEY (id_factura, id_item);


--
-- TOC entry 4750 (class 2606 OID 16622)
-- Name: devoluciones devoluciones_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.devoluciones
    ADD CONSTRAINT devoluciones_pkey PRIMARY KEY (id_factura, id_item);


--
-- TOC entry 4736 (class 2606 OID 16555)
-- Name: empleados empleados_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.empleados
    ADD CONSTRAINT empleados_pkey PRIMARY KEY (id_empleado);


--
-- TOC entry 4746 (class 2606 OID 16591)
-- Name: facturas facturas_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.facturas
    ADD CONSTRAINT facturas_pkey PRIMARY KEY (id_factura);


--
-- TOC entry 4740 (class 2606 OID 16565)
-- Name: items items_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.items
    ADD CONSTRAINT items_pkey PRIMARY KEY (id_item);


--
-- TOC entry 4742 (class 2606 OID 16570)
-- Name: productos productos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.productos
    ADD CONSTRAINT productos_pkey PRIMARY KEY (id_producto);


--
-- TOC entry 4738 (class 2606 OID 16560)
-- Name: proveedores proveedores_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.proveedores
    ADD CONSTRAINT proveedores_pkey PRIMARY KEY (id_proveedor);


--
-- TOC entry 4752 (class 2606 OID 16637)
-- Name: proveedores_productos proveedores_productos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.proveedores_productos
    ADD CONSTRAINT proveedores_productos_pkey PRIMARY KEY (id_proveedor, id_producto);


--
-- TOC entry 4744 (class 2606 OID 16581)
-- Name: servicios servicios_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.servicios
    ADD CONSTRAINT servicios_pkey PRIMARY KEY (id_servicio);


--
-- TOC entry 4757 (class 2606 OID 16608)
-- Name: detalles detalles_id_factura_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detalles
    ADD CONSTRAINT detalles_id_factura_fkey FOREIGN KEY (id_factura) REFERENCES public.facturas(id_factura);


--
-- TOC entry 4758 (class 2606 OID 16613)
-- Name: detalles detalles_id_item_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.detalles
    ADD CONSTRAINT detalles_id_item_fkey FOREIGN KEY (id_item) REFERENCES public.items(id_item);


--
-- TOC entry 4759 (class 2606 OID 16623)
-- Name: devoluciones devoluciones_id_factura_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.devoluciones
    ADD CONSTRAINT devoluciones_id_factura_fkey FOREIGN KEY (id_factura) REFERENCES public.facturas(id_factura);


--
-- TOC entry 4760 (class 2606 OID 16628)
-- Name: devoluciones devoluciones_id_item_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.devoluciones
    ADD CONSTRAINT devoluciones_id_item_fkey FOREIGN KEY (id_item) REFERENCES public.items(id_item);


--
-- TOC entry 4755 (class 2606 OID 16592)
-- Name: facturas facturas_id_cliente_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.facturas
    ADD CONSTRAINT facturas_id_cliente_fkey FOREIGN KEY (id_cliente) REFERENCES public.clientes(id_cliente);


--
-- TOC entry 4756 (class 2606 OID 16597)
-- Name: facturas facturas_id_empleado_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.facturas
    ADD CONSTRAINT facturas_id_empleado_fkey FOREIGN KEY (id_empleado) REFERENCES public.empleados(id_empleado);


--
-- TOC entry 4753 (class 2606 OID 16571)
-- Name: productos productos_id_item_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.productos
    ADD CONSTRAINT productos_id_item_fkey FOREIGN KEY (id_item) REFERENCES public.items(id_item);


--
-- TOC entry 4761 (class 2606 OID 16643)
-- Name: proveedores_productos proveedores_productos_id_producto_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.proveedores_productos
    ADD CONSTRAINT proveedores_productos_id_producto_fkey FOREIGN KEY (id_producto) REFERENCES public.productos(id_producto);


--
-- TOC entry 4762 (class 2606 OID 16638)
-- Name: proveedores_productos proveedores_productos_id_proveedor_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.proveedores_productos
    ADD CONSTRAINT proveedores_productos_id_proveedor_fkey FOREIGN KEY (id_proveedor) REFERENCES public.proveedores(id_proveedor);


--
-- TOC entry 4754 (class 2606 OID 16582)
-- Name: servicios servicios_id_item_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.servicios
    ADD CONSTRAINT servicios_id_item_fkey FOREIGN KEY (id_item) REFERENCES public.items(id_item);


-- Completed on 2025-05-02 13:36:22

--
-- PostgreSQL database dump complete
--


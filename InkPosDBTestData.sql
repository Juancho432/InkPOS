-- Cliente de Prueba
INSERT INTO CLIENTE (ID_Cliente,Nombre,Direccion,Telefono) VALUES (
  '1',
  'Pepito SA',
  'A la vuelta',
  '123'
);
-- Producto de Prueba
INSERT INTO PRODUCTO (ID_Producto,Nombre,Precio,Stock) VALUES (
  '1',
  'Lapicero',
  '1200',
  '10'
);
-- Producto sin stock
INSERT INTO PRODUCTO (ID_Producto,Nombre,Precio,Stock) VALUES (
  '2',
  'Borrador',
  '700',
  '0'
);
-- Producto Eliminado
INSERT INTO PRODUCTO (ID_Producto,Nombre,Precio,Stock) VALUES (
  '3',
  'Sacapuntas',
  '600',
  '-1'
);
-- Admin
INSERT INTO EMPLEADO (ID_Empleado, Nombre, Telefono, Usuario, Contrasena, Es_Admin, Salario, Es_activo) VALUES (
  '1',
  'Juan Manuel',
  '456',
  'Patron',
  '0654e893cc3007912095cf9e957defc8f49dc5b868c320ce13dc7a7a1aec2715', -- QueMira?
  '1',
  '1000000000',
  '1'
);
-- Empleado
INSERT INTO EMPLEADO (ID_Empleado, Nombre, Telefono, Usuario, Contrasena, Es_Admin, Salario, Es_Activo) VALUES (
  '2',
  'Sebastian',
  '789',
  'ElNegro23',
  '5f5b92ff292c5659a8fe79239ff5b82b5a658f2d8c80162bcded09c584ebe09f', -- SoyPobre
  '0',
  '10',
  '1'
);
-- Factura en Efectivo y un producto 2 veces
INSERT INTO FACTURA (ID_Factura,ID_Cliente,ID_Empleado,Fecha,Hora,ID_Transaccion,Total) VALUES (
  NULL,
  '1',
  '2',
  '2025-05-09',
  '16:13:20',
  NULL,
  '2400'
);
-- Factura Con Transferencia y dos productos
INSERT INTO FACTURA (ID_Factura,ID_Cliente,ID_Empleado,Fecha,Hora,ID_Transaccion,Total) VALUES (
  NULL,
  '1',
  '2',
  '2025-05-09',
  '17:07:10',
  '15e4b2',
  '1500'
);
-- Detalle factura 1
INSERT INTO DETALLE (ID_Factura,ID_Producto,Cantidad,Valor) VALUES (
  1,
  '1',
  '2',
  '2400'
);
--Detalle factura 2 - Producto 1
INSERT INTO DETALLE (ID_Factura,ID_Producto,Cantidad,Valor) VALUES (
  2,
  '2',
  '1',
  '700'
);
--Detalle factura 2 - Producto 2
INSERT INTO DETALLE (ID_Factura,ID_Producto,Cantidad,Valor) VALUES (
  2,
  '3',
  '1',
  '600'
);
-- Devolucion de Prueba
INSERT INTO DEVOLUCION (ID_Factura,ID_Producto,Fecha,Hora) VALUES (
  1,
  '1',
  '2025-05-09',
  '17:13:12'
);

--Insercion de clientes
INSERT INTO CLIENTE (ID_Cliente, Nombre, Direccion, Telefono) VALUES 
(2, 'Laura Montoya', 'Calle 10 #20-30', '3112345678'),
(3, 'Pedro Suarez', 'Carrera 15 #5-10', '3123456789'),
(4, 'Sofia Restrepo', 'Avenida 30 #40-50', '3134567890'),
(5, 'Miguel Torres', 'Calle 50 #60-70', '3145678901'),
(6, 'Lucia Vargas', 'Carrera 70 #80-90', '3156789012'),
(7, 'Daniela Mora', 'Calle 100 #110-120', '3167890123'),
(8, 'Andres Castro', 'Carrera 120 #130-140', '3178901234'),
(9, 'Carolina Rios', 'Avenida 150 #160-170', '3189012345'),
(10, 'Sebastian El Caldeño', 'Caldas, Antioquia', '3110000000');

--Inserción de productos
INSERT INTO PRODUCTO (ID_Producto,Nombre,Precio,Stock) VALUES 
(41, 'Lapicero', 1000, 1000),
(42, 'Borrador', 700, 500),
(43, 'Colbon pequeño', 1000, 700),
(4, 'Colbon grande', 5000, 1000),
(5, 'Pegastick pequeño', 1200, 800),
(6, 'Block Base 30 Sin rotulo', 7500, 1000),
(7, 'Cartulina', 1900, 500),
(8, 'Cuaderno sencillo', 4450, 1000),
(9, 'Cinta Enmascarar', 3000, 500),
(10, 'Cinta doble faz', 2700, 500),
(11, 'Porta escarapela + cordon', 3500, 1000),
(12, 'Lapiz rojo', 900, 1000),
(13, 'Block Iris', 6000, 700),
(14, 'Carton paja', 6500, 1000),
(15, 'Marcador Sharpie', 3800, 500),
(16, 'Marcador Sharpie Grande', 5800, 700),
(17, 'Panelita', 500, 1000),
(18, 'Gomitas Trululu Aros', 200, 2000),
(19, 'Chocolatina Jumbo Mediana', 3000, 1000),
(20, 'Chocolatina Jumbo Mini', 1500, 2000),
(21, 'Chocolatina Jet Mini', 600, 1000),
(22, 'Chocolatina Jet Normal', 1500, 2000),
(23, 'Paquete Post-It', 2800, 1000),
(24, 'Colores Norma Sencillos', 22000, 1000),
(25, 'Colores Prismacolor', 75000, 2000),
(26, 'Sobre Manila', 300, 500),
(27, 'Sobre Lluvia de sobres', 1500, 1000),
(28, 'Carpeta Carton', 1000, 1000),
(29, 'Gancho Carpeta Carton', 300, 500),
(30, 'Trident Pequeño', 400, 1000),
(31, 'Sobre Fichas Bibliograficas', 2000, 1000),
(32, 'Resaltador Normal', 2500, 1000),
(33, 'Carpeta de Bisel', 1800, 2000),
(34, 'Resma papel de impresion', 20000, 2000),
(35, 'Audifonos sencillos', 8000, 4000),
(36, 'Cagador V8', 17000, 1000),
(37, 'Bon Bon Bum', 500, 1500),
(38, 'Alcancia pequeña', 500, 1000),
(39, 'Alcancia grande', 2000, 1000),
(40, 'Bolas de icopor medianas', 2000, 1000);
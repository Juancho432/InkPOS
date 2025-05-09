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
INSERT INTO EMPLEADO (ID_Empleado,Nombre,Telefono,Usuario,Contrasena,Es_Admin,Salario) VALUES (
  '1',
  'Patron',
  '456',
  'Patron123',
  '0654e893cc3007912095cf9e957defc8f49dc5b868c320ce13dc7a7a1aec2715', -- QueMira?
  '1',
  '1000000000'
);
-- Empleado
INSERT INTO EMPLEADO (ID_Empleado,Nombre,Telefono,Usuario,Contrasena,Es_Admin,Salario) VALUES (
  '2',
  'Sebastian',
  '789',
  'ElNegro23',
  '5f5b92ff292c5659a8fe79239ff5b82b5a658f2d8c80162bcded09c584ebe09f', -- SoyPobre
  '0',
  '10'
);
-- Factura en Efectivo y un producto 2 veces
INSERT INTO FACTURA (ID_Factura,ID_Cliente,ID_Empleado,Fecha,Hora,ID_Transaccion,Total) VALUES (
  '1',
  '1',
  '2',
  '2025-05-09',
  '16:13:20',
  NULL,
  '2400'
);
-- Factura Con Transferencia y dos productos
INSERT INTO FACTURA (ID_Factura,ID_Cliente,ID_Empleado,Fecha,Hora,ID_Transaccion,Total) VALUES (
  '2',
  '1',
  '2',
  '2025-05-09',
  '17:07:10',
  '15e4b2',
  '1500'
);
-- Detalle factura 1
INSERT INTO DETALLE (ID_Factura,ID_Producto,Cantidad,Valor) VALUES (
  '1',
  '1',
  '2',
  '2400'
);
--Detalle factura 2 - Producto 1
INSERT INTO DETALLE (ID_Factura,ID_Producto,Cantidad,Valor) VALUES (
  '2',
  '2',
  '1',
  '700'
);
--Detalle factura 2 - Producto 2
INSERT INTO DETALLE (ID_Factura,ID_Producto,Cantidad,Valor) VALUES (
  '2',
  '3',
  '1',
  '600'
);
-- Devolucion de Prueba
INSERT INTO DEVOLUCION (ID_Factura,ID_Producto,Fecha,Hora) VALUES (
  '1',
  '1',
  '2025-05-09',
  '17:13:12'
);
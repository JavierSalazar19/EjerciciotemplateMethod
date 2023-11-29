using EjerciciotemplateMethod;

Pedido pedidoEspaña = new PedidoEspaña();
pedidoEspaña.setImporteSinIVA(1234.45);
pedidoEspaña.calculaPrecioConIva();
pedidoEspaña.visualiza();

Pedido pedidoLuxemburgo = new PedidoLuxemburgo();
pedidoEspaña.setImporteSinIVA(1234.45);
pedidoEspaña.calculaPrecioConIva();
pedidoEspaña.visualiza();
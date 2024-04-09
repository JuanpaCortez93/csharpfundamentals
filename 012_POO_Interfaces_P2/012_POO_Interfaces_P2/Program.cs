
using _012_POO_Interfaces_P2.Services;

Avisos avisoGeneral = new Avisos();
Avisos avisoSRI = new Avisos("SRI", "Pague el impuesto a la Renta ahora y beneficiese de un descuento.");

avisoGeneral.ShowAlert();
avisoSRI.ShowAlert();
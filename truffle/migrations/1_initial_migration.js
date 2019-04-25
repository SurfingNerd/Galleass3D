//const Migrations = artifacts.require("Migrations");

const Galleass =  artifacts.require("Galleass");
const Timber = artifacts.require("Timber");
const Fillet = artifacts.require("Fillet");


module.exports = async function(deployer) {
  //deployer.deploy(Migrations);
  //console.log('start Deploy...');
  await deployer.deploy(Galleass);
  var gallAddr = Galleass.address;
  //console.log('gal: ' +gallAddr);
  await deployer.deploy(Timber, gallAddr);
  await deployer.deploy(Fillet, gallAddr);
  //console.log('timber: ' + Timber.address);
  
};

//const Migrations = artifacts.require("Migrations");

const Galleass =  artifacts.require("Galleass");
const Timber = artifacts.require("Timber");
const Fillet = artifacts.require("Fillet");
const Dogger = artifacts.require("Dogger");
const Copper = artifacts.require("Copper");

module.exports = async function(deployer) {
  //deployer.deploy(Migrations);
  //console.log('start Deploy...');
  
  
  var accounts = await web3.eth.getAccounts();
  var deploymentAccount = accounts[0];

  await deployer.deploy(Galleass, 'Thomas Haller');
  var gallAddr = Galleass.address;
  //console.log('gal: ' +gallAddr);
  var timber = await deployer.deploy(Timber, gallAddr);

  var fillet = await deployer.deploy(Fillet, gallAddr);
  var dogger = await deployer.deploy(Dogger, gallAddr);
  var copper = await deployer.deploy(Copper, gallAddr);
  
  //console.log(timber);
  var mintWoodTransaction = await timber.mint.sendTransaction(deploymentAccount, 10);
  
  var balance = await timber.balanceOf.call(deploymentAccount);
  console.log('minted: ' + balance);

};

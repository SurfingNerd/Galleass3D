//const Migrations = artifacts.require("Migrations");

const Galleass =  artifacts.require("Galleass");
const Timber = artifacts.require("Timber");
const Fillet = artifacts.require("Fillet");
const Dogger = artifacts.require("Dogger");
const Copper = artifacts.require("Copper");

const Bay = artifacts.require("Bay");


module.exports = async function(deployer) {
  //deployer.deploy(Migrations);
  //console.log('start Deploy...');
  const __deployer = deployer;

  
  var accounts = await web3.eth.getAccounts();
  var deploymentAccount = accounts[0];

  var galleas = await deployer.deploy(Galleass, 'Thomas Haller');
  const __mainContract = galleas;
  //const var gallAddr = Galleass.address;

  async function deployContract(contractName){
    console.log('Deploying ' + contractName);
    const contractArtifact = artifacts.require(contractName);
    const deployedContract = await deployer.deploy(contractArtifact, __mainContract.address);
    const setContractResult = await __mainContract.setContract.sendTransaction(web3.utils.fromAscii(contractName), deployedContract.address);
  
    if (setContractResult) {
      return deployedContract;
    } else {
      return null;
    }
  }

  

  const timber = await deployContract('Timber');
  const fillet = await deployContract('Fillet');
  const dogger = await deployContract('Dogger');
  const copper = await deployContract('Copper');
  const bay = await deployContract('Bay');
  const citizen = await deployContract('Citizens');
  const land = await deployContract('Land');
  //const lanLib = await deployContract('LandLib');


  //console.log('gal: ' +gallAddr);
  // var timber = await deployer.deploy(Timber, gallAddr);
  // var fillet = await deployer.deploy(Fillet, gallAddr);
  // var dogger = await deployer.deploy(Dogger, gallAddr);
  // var copper = await deployer.deploy(Copper, gallAddr);
  
  //console.log(timber);
  var mintWoodTransaction = await timber.mint.sendTransaction(deploymentAccount, 10);
  
  var balance = await timber.balanceOf.call(deploymentAccount);
  console.log('minted: ' + balance);

};

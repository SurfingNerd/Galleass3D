//const Migrations = artifacts.require("Migrations");

const Galleass =  artifacts.require("Galleass");

module.exports = async function(deployer) {
  //deployer.deploy(Migrations);
  //console.log('start Deploy...');
  const __deployer = deployer;

  
  var accounts = await web3.eth.getAccounts();
  var deploymentAccount = accounts[0];
  console.log('deploying main contract with account:' + deploymentAccount); 
  var galleas = await deployer.deploy(Galleass, 'Thomas Haller');
  console.log('main account deployed!'); 
  //const __mainContract = galleas;
  //const var gallAddr = Galleass.address;

  async function deployContract(contractName){
    console.log('Deploying ' + contractName);
    const contractArtifact = artifacts.require(contractName);
    const deployedContract = await deployer.deploy(contractArtifact, galleas.address);
    const setContractResult = await galleas.setContract.sendTransaction(web3.utils.fromAscii(contractName), deployedContract.address);
  
    if (setContractResult) {
      return deployedContract;
    } else {
      return null;
    }
  }

  async function setPermission(contract, permissionName) {
    // function setPermission(address _contract, bytes32 _permission, bool _value) 
    await galleas.setPermission(contract.address, web3.utils.fromAscii(permissionName), true);
  }

  const timber = await deployContract('Timber');
  const fillet = await deployContract('Fillet');
  const dogger = await deployContract('Dogger');
  const copper = await deployContract('Copper');
  const bay = await deployContract('Bay');
  const citizen = await deployContract('Citizens');
  const citizenLib = await deployContract('CitizensLib');
  const land = await deployContract('Land');
  const timberCamp = await deployContract('TimberCamp');
  const landLib = await deployContract('LandLib');
  const harbor = await deployContract('Harbor');
  const fishMonger = await deployContract('Fishmonger');
  const village = await deployContract('Village');
  const market = await deployContract('Market');
  const sea = await deployContract('Sea');

  setPermission(bay, 'transferDogger');
  setPermission(bay, 'updateExperience');

  setPermission(landLib, 'useCitizens');
  setPermission(landLib, 'mintTimber');
  setPermission(landLib, 'mintStone');
  setPermission(landLib, 'mintGreens');
  setPermission(landLib, 'transferStone');
  setPermission(landLib, 'transferGreens');
  setPermission(landLib, 'transferTimber');

  setPermission(timberCamp, 'mintTimber');


  setPermission(harbor, 'buildDogger');
  setPermission(harbor, 'buildSchooner');
  setPermission(harbor, 'updateExperience');
  setPermission(harbor, 'embarkShips');
  
  
  setPermission(fishMonger, 'transferFish');
  setPermission(fishMonger, 'mintFillet');
  setPermission(fishMonger, 'updateExperience');


  setPermission(village, 'createCitizens');

  setPermission(citizenLib, 'transferFood');


  setPermission(market, 'transferTimber');

  

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

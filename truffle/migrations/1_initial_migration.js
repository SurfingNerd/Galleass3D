//const Migrations = artifacts.require("Migrations");


// const Web3 = require('web3');
// const web3 = new Web3();

const Registry = artifacts.require("WorldsRegistry");
const Galleass =  artifacts.require("Galleass");



//todo: some of the parameters might be calculatable out of the raw transaction.
async function deployWithDeterministicAddress(payingAccount, expectedContractAddress, singleUsedCreatorAddress, gasCosts, rawTx) {

  // deploying a contract with a static adress.
  // see: https://eips.ethereum.org/EIPS/eip-1820

  const gotCode = await web3.eth.getCode(expectedContractAddress);

  if (gotCode === '0x') {
    // contract does not exist, deploy new.
    console.log('transfering funds for single use account');
    await web3.eth.sendTransaction({ from: payingAccount,  to: singleUsedCreatorAddress, value: gasCosts})
    console.log('creating contract');
    const introspectionResult = await web3.eth.sendSignedTransaction(rawTx);
    console.log('contract got deployed: ', introspectionResult.contractAddress);

    if (introspectionResult.contractAddress.toLowerCase() !== expectedContractAddress.toLowerCase()) {
      console.error('MISSMATCH: the expected contract Address did not match the actual contract Address');
    }

  } else {
    console.log('skipping: contract already exists');
  }
}

async function deployEip1820(payingAccount) {

  //deploy pseudo-introspection Registry Contract.
  // see: https://eips.ethereum.org/EIPS/eip-1820
  const expectedContractAddress = '0x1820a4B7618BdE71Dce8cdc73aAB6C95905faD24';
  const singleUsedCreatorAddress = '0xa990077c3205cbDf861e17Fa532eeB069cE9fF96';
  const gasCosts = web3.utils.toHex('80000000000000000');
  const rawTx = '0xf90a388085174876e800830c35008080b909e5608060405234801561001057600080fd5b506109c5806100206000396000f3fe608060405234801561001057600080fd5b50600436106100a5576000357c010000000000000000000000000000000000000000000000000000000090048063a41e7d5111610078578063a41e7d51146101d4578063aabbb8ca1461020a578063b705676514610236578063f712f3e814610280576100a5565b806329965a1d146100aa5780633d584063146100e25780635df8122f1461012457806365ba36c114610152575b600080fd5b6100e0600480360360608110156100c057600080fd5b50600160a060020a038135811691602081013591604090910135166102b6565b005b610108600480360360208110156100f857600080fd5b5035600160a060020a0316610570565b60408051600160a060020a039092168252519081900360200190f35b6100e06004803603604081101561013a57600080fd5b50600160a060020a03813581169160200135166105bc565b6101c26004803603602081101561016857600080fd5b81019060208101813564010000000081111561018357600080fd5b82018360208201111561019557600080fd5b803590602001918460018302840111640100000000831117156101b757600080fd5b5090925090506106b3565b60408051918252519081900360200190f35b6100e0600480360360408110156101ea57600080fd5b508035600160a060020a03169060200135600160e060020a0319166106ee565b6101086004803603604081101561022057600080fd5b50600160a060020a038135169060200135610778565b61026c6004803603604081101561024c57600080fd5b508035600160a060020a03169060200135600160e060020a0319166107ef565b604080519115158252519081900360200190f35b61026c6004803603604081101561029657600080fd5b508035600160a060020a03169060200135600160e060020a0319166108aa565b6000600160a060020a038416156102cd57836102cf565b335b9050336102db82610570565b600160a060020a031614610339576040805160e560020a62461bcd02815260206004820152600f60248201527f4e6f7420746865206d616e616765720000000000000000000000000000000000604482015290519081900360640190fd5b6103428361092a565b15610397576040805160e560020a62461bcd02815260206004820152601a60248201527f4d757374206e6f7420626520616e204552433136352068617368000000000000604482015290519081900360640190fd5b600160a060020a038216158015906103b85750600160a060020a0382163314155b156104ff5760405160200180807f455243313832305f4143434550545f4d4147494300000000000000000000000081525060140190506040516020818303038152906040528051906020012082600160a060020a031663249cb3fa85846040518363ffffffff167c01000000000000000000000000000000000000000000000000000000000281526004018083815260200182600160a060020a0316600160a060020a031681526020019250505060206040518083038186803b15801561047e57600080fd5b505afa158015610492573d6000803e3d6000fd5b505050506040513d60208110156104a857600080fd5b5051146104ff576040805160e560020a62461bcd02815260206004820181905260248201527f446f6573206e6f7420696d706c656d656e742074686520696e74657266616365604482015290519081900360640190fd5b600160a060020a03818116600081815260208181526040808320888452909152808220805473ffffffffffffffffffffffffffffffffffffffff19169487169485179055518692917f93baa6efbd2244243bfee6ce4cfdd1d04fc4c0e9a786abd3a41313bd352db15391a450505050565b600160a060020a03818116600090815260016020526040812054909116151561059a5750806105b7565b50600160a060020a03808216600090815260016020526040902054165b919050565b336105c683610570565b600160a060020a031614610624576040805160e560020a62461bcd02815260206004820152600f60248201527f4e6f7420746865206d616e616765720000000000000000000000000000000000604482015290519081900360640190fd5b81600160a060020a031681600160a060020a0316146106435780610646565b60005b600160a060020a03838116600081815260016020526040808220805473ffffffffffffffffffffffffffffffffffffffff19169585169590951790945592519184169290917f605c2dbf762e5f7d60a546d42e7205dcb1b011ebc62a61736a57c9089d3a43509190a35050565b600082826040516020018083838082843780830192505050925050506040516020818303038152906040528051906020012090505b92915050565b6106f882826107ef565b610703576000610705565b815b600160a060020a03928316600081815260208181526040808320600160e060020a031996909616808452958252808320805473ffffffffffffffffffffffffffffffffffffffff19169590971694909417909555908152600284528181209281529190925220805460ff19166001179055565b600080600160a060020a038416156107905783610792565b335b905061079d8361092a565b156107c357826107ad82826108aa565b6107b85760006107ba565b815b925050506106e8565b600160a060020a0390811660009081526020818152604080832086845290915290205416905092915050565b6000808061081d857f01ffc9a70000000000000000000000000000000000000000000000000000000061094c565b909250905081158061082d575080155b1561083d576000925050506106e8565b61084f85600160e060020a031961094c565b909250905081158061086057508015155b15610870576000925050506106e8565b61087a858561094c565b909250905060018214801561088f5750806001145b1561089f576001925050506106e8565b506000949350505050565b600160a060020a0382166000908152600260209081526040808320600160e060020a03198516845290915281205460ff1615156108f2576108eb83836107ef565b90506106e8565b50600160a060020a03808316600081815260208181526040808320600160e060020a0319871684529091529020549091161492915050565b7bffffffffffffffffffffffffffffffffffffffffffffffffffffffff161590565b6040517f01ffc9a7000000000000000000000000000000000000000000000000000000008082526004820183905260009182919060208160248189617530fa90519096909550935050505056fea165627a7a72305820377f4a2d4301ede9949f163f319021a6e9c687c292a5e2b2c4734c126b524e6c00291ba01820182018201820182018201820182018201820182018201820182018201820a01820182018201820182018201820182018201820182018201820182018201820'
  
  await deployWithDeterministicAddress(payingAccount, expectedContractAddress, singleUsedCreatorAddress, gasCosts, rawTx)
}


module.exports = async function(deployer) {
  //deployer.deploy(Migrations);
  //console.log('start Deploy...');
  const __deployer = deployer;

  var accounts = await web3.eth.getAccounts();
  var deploymentAccount = accounts[0];

  console.log('deploying main contract with account:' + deploymentAccount); 

  await deployEip1820(accounts[0]);

  //console.log('Registry: ', new Registry());
  

  return;

  //var registry = await Registry.at('0x6EB0fadc34060AF5EfB053b4cB413CE5809b6f16');
  var registry = await deployer.deploy(Registry);
  console.log('deployed a WorldRegistry at ' + registry.address);

  var galleas = await deployer.deploy(Galleass);
  console.log('first Galleas world deployed at ' + galleas.address);

  await registry.registerGalleasWorld.sendTransaction(galleas.address, web3.utils.fromAscii('Root World'));

  var seconds = Math.round(new Date() / 1000);

  var secondsSinceGameBirth = seconds - 1556310063;

  console.log('seconds: ' + seconds);

  //await registry.registerGalleasWorld.sendTransaction(galleas.address, deploymentAccount, web3.utils.fromAscii('test - world sec:' + secondsSinceGameBirth));
  //const __mainContract = galleas;
  //const var gallAddr = Galleass.address;

  async function deployContract(contractName){
    console.log('Deploying ' + contractName + ' with Galleass Address ' + galleas.address);
    const contractArtifact = artifacts.require(contractName);
    const deployedContract = await deployer.deploy(contractArtifact, galleas.address);
    const setContractResult = await galleas.setContract.sendTransaction(web3.utils.fromAscii(contractName), deployedContract.address);
    if (setContractResult) {
      deployedContract.contractName = contractName;
      return deployedContract;
    } else {
      return null;
    }
  }

  async function setPermission(contract, permissionName) {
    
    console.log("setting " + contract.address + " " + contract.contractName + " permission:" + permissionName);

    // function setPermission(address _contract, bytes32 _permission, bool _value) 
    var setPermissionResult = await galleas.setPermission(contract.address, web3.utils.fromAscii(permissionName), true);
   
    if (!setPermissionResult.receipt.status) {
      console.error("FAILED: setting " + contract.address + " " + contract.contractName + " permission:" + permissionName);
    }
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
  const catfish = await deployContract('Catfish');

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

  catfish.mint.sendTransaction(deploymentAccount, 10);
  

  //console.log(copper);

  // console.log('Generating  Land...');
  // await landLib.generateLand.sendTransaction();



  // const fs = require('fs');
  // fs.writeFile("./build/latestGalleasAddress.txt", galleas.address, function(err) {
  //   if(err) {
  //       return console.log(err);
  //   }

  //   console.log("latest Galleass address written to: build/latestGalleasAddress.txt");
  // }); 
  // galleas.address

};

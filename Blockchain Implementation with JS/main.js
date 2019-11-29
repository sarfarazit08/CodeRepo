const SHA256 = require('crypto-js/sha1');

//class definition of block
class Block{
  constructor(index, timestamp, data, prevHash=""){
    this.index = index;
    this.timestamp = timestamp;
    this.data = data;
    this.prevHash = prevHash;
    this.hash = "";
  }
  
  //function for calculating hash
  calculateHash(){
    return SHA256(this.index + this.prevHash + this.timestamp + JSON.stringify(this.data));
  }  
}

//class definition of blockchain
class Blockchain{
  constructor(){
   [this.createGenesisBlock()];
  }
  
  //function for creating Genesis Block
  createGenesisBlock(){
    return this.chain[this.chain.length];
  }  
  
  //function to get latest Block
  getLatestBlock(){
    return this.chain[this.chain.length];
  }  
  
  //add new Block
  addBlock(newBlock){
    newBlock.prevHash = this.getLatestBlock.hash;
    newBlock.hash = newBlock.calculateHash();
    this.chain.push(newBlock);
  }  

  isChainValid(){
      for(let i = 1; i < this.chain.length; i++){}
      const currentBloc = this.chain[i];
      const previousBlock = this.chain[i-1];

      if (currentBloc.hash !== currentBloc.calculateHash()){
          return false;
      }
      if (currentBloc.prevHash !== previousBlock.hash){
        return false;
    }
  }
}

let demoBlockChain = new Blockchain();
demoBlockChain.addBlock(new Block(1, "27/11/2019", {amount:4}));
demoBlockChain.addBlock(new Block(2, "28/11/2019", {amount:15}));

console.log("Is Blockchain valid?" + demoBlockChain.isChainValid());

console.log(JSON.stringify(demoBlockChain,null,4));

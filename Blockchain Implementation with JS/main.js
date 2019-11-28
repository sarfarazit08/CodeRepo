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
}

//function for calculating hash

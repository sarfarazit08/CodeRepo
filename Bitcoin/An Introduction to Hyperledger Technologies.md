# Blockchain for Business : An Introduction to Hyperledger Technologies

# [The Linux Foundation](https://www.linuxfoundation.org/)

The Linux Foundation partners with the world's leading developers and companies to solve the hardest technology problems and accelerate open technology development and commercial adoption. The Linux Foundation makes it its mission to provide experience and expertise to any initiative working to solve complex problems through open source collaboration, providing the tools to scale open source projects: security best practices, governance, operations and ecosystem development, training and certification, licensing, and promotion.

Linuxis the world's largest and most pervasive open source software project in history. The Linux Foundation is home to Linux creator Linus Torvalds and lead maintainer Greg Kroah-Hartman, and provides a neutral home where Linux kernel development can be protected and accelerated for years to come. The success of Linux has catalyzed growth in the open source community, demonstrating the commercial efficacy of open source and inspiring countless new projects across all industries and levels of the technology stack.

The Linux Foundation's work today extends far beyond Linux, fostering innovation at every layer of the software stack. The Linux Foundation is the umbrella organization for many critical open source projects that power corporations today, spanning all industry sectors:

*   Big data and analytics: [ODPi](https://www.odpi.org/), [R Consortium](https://www.r-consortium.org/)
*   Networking: [OpenDaylight](https://www.opendaylight.org/), [OPNFV](https://www.opnfv.org/)
*   Embedded: [Dronecode](https://www.dronecode.org/), [Zephyr](https://www.zephyrproject.org/)
*   Web tools: [JS Foundation](https://js.foundation/), [Node.js](https://nodejs.org/en/)
*   Cloud computing: [Cloud Foundry](https://www.cloudfoundry.org/), [Cloud Native Computing Foundation](https://cncf.io/), [Open Container Initiative](https://www.opencontainers.org/)
*   Automotive: [Automotive Grade Linux](https://www.automotivelinux.org/)
*   Security: [The Core Infrastructure Initiative](https://www.coreinfrastructure.org/)
*   Blockchain: [Hyperledger](https://www.hyperledger.org/)
*   And many more.

# [Hyperledger](https://www.hyperledger.org/) 

Hyperledger is the umbrella open source project that The Linux Foundation has created and hosted since 2015. It aims at advancing and promoting cross-industry blockchain technologies to ensure accountability, transparency, and trust among business partners. As a result, Hyperledger makes business network and transactions more efficient.

These benefits are valued by leaders across many industries, including technology, finance, healthcare, supply chain, and automotive, among several others.

Hyperledger offers different blockchain platforms. This course will present three of them: **Iroha, Sawtooth, and Fabric**.

### Introduction

Discover the power of business blockchains and distributed ledger technologies with an overview of Hyperledger and introductions to its key frameworks. Blockchains have quickly gained popularity in several industries. This introductory course is carefully curated for both nontechnical and technical audiences. It examines blockchains for the enterprise and a number of pertinent use cases. Hyperledger is a group of open source blockchain-based projects organized by The Linux Foundation. Industries are researching how blockchains may increase efficiency and solve business problems associated with data privacy, security, information sharing, and inclusion. What are blockchain & distributed ledger technologies and how might they impact global business?

The course covers key features of blockchain technologies and the differentiators between various types of Hyperledger blockchain frameworks. We shall start with ‘What is blockchain?’ and open the discussion on where blockchain technology is suitable for your business requirements. We then take a deep dive into the enterprise-ready Hyperledger blockchain frameworks by guiding students through a demonstrated scenario.

Students with a technical background should be able to perform clean installations of Hyperledger Sawtooth and Hyperledger Fabric, as well as, develop simple applications on top of these frameworks. They will gain an understanding of various types of blockchains and which one is most suitable for any particular project.

Students with a business background should gain an understanding of how blockchains work and how they can create value for their business through cost savings and efficiencies in terms of speed and simplicity. They will view how information is generated, stored, and shared in various blockchains, as well as, gain tools to evaluate whether or not a blockchain solution would be suitable for their particular business case.

### Learning Objectives :

+ Describe Business Blockchain and Distributed Ledger Technologies.
+ Gain familiarity with current Hyperledger projects and cross-industry use cases.
+ Perform clean installations of the Hyperledger Sawtooth and Hyperledger Fabric frameworks.
+ Explore a sample use case/application in the context of the Hyperledger Sawtooth and Hyperledger Fabric frameworks.
+ Build simple applications on top of Hyperledger Sawtooth and Hyperledger Fabric.
+ Become involved in and contribute to the open source Hyperledger projects.

# Chapter 1. Discovering Blockchain Technologies
    
## Introduction

+ Discuss blockchain and distributed ledger technologies (DLT).
+ Explore permissioned and permissionless blockchains and their key characteristics.
+ Discuss various components of distributed ledger technologies, including consensus algorithms and smart contracts.
+ Provide a high-level explanation of what Hyperledger is.

Looking back to the last half century of computer technologies and architectures, one may observe a trend of fluctuation between the centralization and subsequent decentralization of computing power, storage, infrastructure, protocols, and code.

Mainframe computers are largely centralized. They typically house all computing power, memory, data storage, and code. Access to mainframes is mainly by 'dumb terminals', which only take inputs and outputs, and do not store or process data.

With the advent of personal computers and private networks, similar computational capabilities were now housed both on the clients, as well as the servers. This, in part, gave rise to the 'client-server' architecture, which supported the development of relational database systems. Massive data sets, which are housed on mainframes, could move onto a distributed architecture. This data could replicate from server to server, and subsets of the data could be accessed and processed on clients, and then, synced back to the server.

Over time, Internet and cloud computing architectures enabled global access from a variety of computing devices; whereas mainframes were largely designed to address the needs of large corporations and governments. Even though this 'cloud architecture' is decentralized in terms of hardware, it has given rise to application-level centralization (e.g. Facebook, Twitter, Google, etc).

Currently, we are witnessing the transition from centralized computing, storage, and processing to decentralized architectures and systems. According to [Muneeb Ali](https://medium.com/@muneeb/the-next-wave-of-computing-743295b4bc73), these systems aim to

> "give explicit control of digital assets to end-users and remove the need to trust any third-party servers and infrastructure".

Distributed ledger technology is one of the key innovations making this shift possible.

## Distributed Ledger Technology (DLT)

A distributed ledger is a type of data structure which resides across multiple computer devices, generally spread across locations or regions.

Distributed Ledger Technology includes blockchain technologies and smart contracts. While distributed ledgers existed prior to Bitcoin, the Bitcoin blockchain marks the convergence of a host of technologies, including timestamping of transactions, Peer-to-Peer (P2P) networks, cryptography, and shared computational power, along with a new consensus algorithm. 

In summary, distributed ledger technology generally consists of three basic components:

+ A data model that captures the current state of the ledger
+ A language of transactions that changes the ledger state
+ A protocol used to build consensus among participants around which transactions will be accepted, and in what order, by the ledger.

### Blockchains

According to hyperledger.org,

> "A blockchain is a peer-to-peer distributed ledger forged by consensus, combined with a system for "smart contracts" and other assistive technologies."

+ Smart contracts are simply computer programs that execute predefined actions when certain conditions within the system are met.
+ Consensus refers to a system of ensuring that parties agree to a certain state of the system as the true state.

Blockchain is a specific form or subset of distributed ledger technologies, which constructs a chronological chain of blocks, hence the name 'block-chain'. A block refers to a set of transactions that are bundled together and added to the chain at the same time. In the Bitcoin blockchain, the miner nodes bundle unconfirmed and valid transactions into a block. Each block contains a given number of transactions. In the Bitcoin network, miners must solve a cryptographic challenge to propose the next block. This process is known as 'proof of work', and requires significant computing power. We shall discuss proof of work in more detail in the Consensus Algorithms section. Checkout [A brief history of blockchain technology](https://hbr.org/2017/02/a-brief-history-of-blockchain).

Timestamping is another key feature of blockchain technology. Each block is timestamped, with each new block referring to the previous block. Combined with cryptographic hashes, this timestamped chain of blocks provides an immutable record of all transactions in the network, from the very first (or genesis) block.

A block commonly consists of four pieces of metadata:

+ The reference to the previous block
+ The proof of work, also known as a nonce
+ The timestamp
+ The Merkle tree root for the transactions included in this block.

### [Merkle Tree](http://chimera.labs.oreilly.com/books/1234000001802/ch07.html#_structure_of_a_block)

The Merkle tree, also known as a binary hash tree, is a data structure that is used to store hashes of the individual data in large datasets in a way to make the verification of the dataset efficient. It is an anti-tamper mechanism to ensure that the large dataset has not been changed. The word 'tree' is used to refer to a branching data structure in computer science, as seen in the image below. According to Andreas M. Antonopoulos, in the Bitcoin protocol,

> "Merkle trees are used to summarize all the transactions in a block, producing an overall digital fingerprint of the entire set of transactions, providing a very efficient process to verify whether a transaction is included in a block."

<img src="https://prod-edxapp.edx-cdn.org/assets/courseware/v1/5bef2699f0c33f98eb3ccb6c2526b447/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Bitcoin_Block_Data.png" alt="Merkle tree" />

### Transactions

The record of an event, cryptographically secured with a digital signature, that is verified, ordered, and bundled together into blocks, form the transactions in the blockchain. In the Bitcoin blockchain, transactions involve the transfer of bitcoins, while in other blockchains, transactions may involve the transfer of any asset or a record of some service being rendered. Furthermore, a smart contract within the blockchain may allow automatic execution of transactions upon meeting predefined criteria.

Cryptography has a key role to play both in the security, as well as in the immutability of the transactions recorded on blockchains. Cryptography is the study of the techniques used to allow secure communication between different parties and to ensure the authenticity and immutability of the data being communicated. For blockchain technologies, cryptography is used to prove that a transaction was created by the right person. It is also used to link transactions into a block in a tamper-proof way, as well as create the links between blocks, to form a blockchain.

### Differences between Blockchains and Databases

Blockchain technology has some key differentiators from databases. 

A blockchain is a write-only data structure, where new entries get appended onto the end of the ledger. Every new block gets appended to the block chain by linking to the previous block's 'hash' (you can check the Glossary tab for a refresher on hash functions). There are no administrator permissions within a blockchain that allow editing or deleting of data.

In a relational database, data can be easily modified or deleted. Typically, there are database administrators who may make changes to any part of the data and/or its structure. Additionally, blockchains were designed for decentralized applications, whereas relational databases, in general, were originally designed for centralized applications, where a single entity controls the data.

<img src="https://prod-edxapp.edx-cdn.org/assets/courseware/v1/d387060c18e43cb6f676f10c56443ce7/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Centralized_Databases_vs_Blockchain.png" alt="Centralized_Databases_vs_Blockchain" />

### Types of Blockchains
 
A blockchain can be both permissionless (like Bitcoin or Ethereum) or permissioned (like the different Hyperledger blockchain frameworks). A permissionless blockchain is also known as a public blockchain, because anyone can join the network. A permissioned blockchain, or private blockchain, requires pre-verification of the participating parties within the network, and these parties are usually known to each other.

The choice between permissionless versus permissioned blockchains should be driven by the particular application at hand (or use case). Most enterprise use cases involve extensive vetting before parties agree to do business with each other. An example where a number of businesses exchange information is the supply chain management. The supply chain management is an ideal use case for permissioned blockchains. You would not want non-vetted companies participating in the network. Each participant that is involved in the supply chain would require permissions to execute transactions on the blockchain. These transactions would allow other companies to understand where in the supply chain a particular item is. 

On the contrary, when a network can 'commoditize' trust, facilitating parties to transact without necessarily having to verify each other's identity, like the Bitcoin blockchain, a permissionless blockchain is more suitable. Many of these instances involve the sale or distribution to the public. Cryptocurrencies and [Initial Coin Offerings](https://www.sec.gov/oiea/investor-alerts-and-bulletins/ib_coinofferings) (which are not backed by national governments) usually involve implementations of permissionless blockchains.

<img src="https://prod-edxapp.edx-cdn.org/assets/courseware/v1/4c3c4fb5206767b4fe0a5b9aaa201ed3/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Types_of_Blockchains.png" alt="Types_of_Blockchains" />

### Peer-to-Peer Network Architecture

Historically, most applications utilize a central server (or servers). For one user/client to send a message to another user/client in the network, the request has to be sent to the hub or a central server, which then directs it to the right computer.

Peer-to-peer (P2P) networks were first made popular by Napster (and later BitTorrent) and consist of computer systems which are directly connected to each other via the Internet, without a central server. Peers contribute to the computing power and storage that is required for the upkeep of the network. P2P networks are generally considered to be more secure than centralized networks, as they do not have a single point of attack, as in the case of a server-based network, where the security of the entire network can be compromised if the central server is successfully attacked. As a result, large corporations invest significant amounts of financial resources to fortify their central servers, and yet, a total cost of $445 billion to the global economy in cyberspace crimes was estimated by the World Economic Forum's 2016 Global Risk Report.

Permissionless P2P systems do not require a set amount of peers to be online and are generally slower. Permissioned P2P networks have to guarantee uptime and require a high level of quality of service on the communication links.

+ Proof of Work
+ Proof of Stake
+ Proof of Elapsed Time

<img src="https://prod-edxapp.edx-cdn.org/assets/courseware/v1/99e70ee58cba3930923df89a997e65be/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Network_Architectures.png" alt="Network_Architectures" />

### Immutability of Data
 
The immutability of the data which sits on the blockchain is perhaps the most powerful and convincing reason to deploy blockchain-based solutions for a variety of socio-economic processes which are currently recorded on centralized servers. This immutability, or 'unchanging over time' feature makes the blockchain useful for accounting, financial transactions, identity management, and asset ownership, management and transfer, just to name a few examples. Once a transaction is written onto the blockchain, no one can change it, or, at least, it would be extremely difficult to change it.

> According to [Antony Lewis](https://www.linkedin.com/pulse/gentle-introduction-immutability-blockchains-antony-lewis/), the Director of Research at R3, - "When people say that blockchains are immutable, they don't mean that the data can't be changed, they mean it is extremely hard to change without collusion, and if you try, it's extremely easy to detect the attempt."

Let's dig into this statement a bit further. It is extremely hard to change the transactions in a blockchain, because each block is linked to the previous block by including the previous block's hash. This hash includes the Merkle root hash of all the transactions in the previous block. If a single transaction were to change, not only would the Merkle root hash change, but so too would the hash contained in the changed block. In addition, each subsequent block would need to be updated to reflect this change. In the case of proof of work, the amount of energy required to recalculate the nonce for this block and each subsequent block would be prohibitive. On the other hand, if someone did modify a transaction in a block without going through the necessary steps to update the subsequent blocks, it would be easy to recalculate the hashes used in the blocks and determine that something is amiss.

Let's look at an example of how this works. In the following diagram, we see the original blocks and the transactions for Block 11. Specifically, we see that the Merkle root for the transactions in Block 11 is Hash #ABCD, which is the combined hash for the four transactions in this block. Now, let's say that someone comes in and attempts to change Transaction A to Transaction A'. This, in turn, modifies the hashes that are stored in the Merkle tree, and the Merkle root changes to Hash #A'BCD. In addition, the Previous Block hash stored in Block 12 also needs to be modified to reflect the overall change in the hash for Block 11.

<img src="https://prod-edxapp.edx-cdn.org/assets/courseware/v1/7b24ffd61a0fcdc9c147463892a273da/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/BLOCKCHAIN_IMMUTABILITY.png" alt="BLOCKCHAIN IMMUTABILITY" />

### Blockchain Applications

Since blockchain is a new form of digital infrastructure, applications built on top of a blockchain provide a gateway to accessing information that sits on that blockchain. In other words, clients/users interact with the blockchain through applications. Starting from the simple wallets that hold bitcoins, sophisticated applications which encompass applications addressing digital identity (e.g. UPort, KYC-Chain, Netki, etc.), and complex financial transactions are being built on the blockchain.

A more exhaustive list of companies using blockchain technology for identity management and authentication can be found [here](https://letstalkpayments.com/22-companies-leveraging-blockchain-for-identity-management-and-authentication/).

For more details about blockchain applications, you can refer to Daniel Palmer's article at [coindesk.com](coindesk.com).

### Smart Contracts

Smart contracts are simply computer programs that execute predefined actions when certain conditions within the system are met. Smart contracts provide the **language of transactions** that allow the ledger state to be modified. They can facilitate the exchange and transfer of anything of value (e.g. shares, money, content, property).

<img src="https://prod-edxapp.edx-cdn.org/assets/courseware/v1/ec30b3736f17bdbbc1a7bc6e08380094/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Blockchain_and_Smar_Contracts_-_Flow_Diagram.png" alt="BLOCKCHAIN IMMUTABILITY" />

## Bitcoin and Ethereum Blockchains

### Bitcoin - A Popular Blockchain Deployment

With the invention of the peer-to-peer (P2P) cash system known as Bitcoin in 2008, we have an example of a global decentralized payment network with a distributed and publicly-owned infrastructure, operating as a 'permissionless' system. There is a persuasive case that Bitcoin is the first 'killer application' of decentralized computing. One can send and receive bitcoins anywhere in the world in a completely P2P manner, without having to intermediate through a trusted third party, such as a bank.

According to the [Coin Market Capitalizations website](https://coinmarketcap.com/currencies/bitcoin/), as of October 2017, bitcoin's market capitalization (market cap) was nearly $100 billion. 

### Bitcoin and Cryptoeconomics
 
Bitcoin has also ushered in tremendous academic and research interest in the area of Cryptoeconomics and Cryptoeconomic security.

> According to [Vitalik Buterin](https://www.youtube.com/watch?v=pKqdjaH1dRo), - "Cryptoeconomics is about building systems that have certain desired properties using cryptography to prove properties about messages that happened in the past while using economic incentives defined inside the system to encourage desired properties to hold into the future."

In other words, the field of Cryptoeconomics explores the intersection of cryptography and economic incentives. While cryptography is used for ensuring network security at various levels and functions, the built-in economic incentives provided to the participating nodes in the network ensures that, at any given point, the majority of players in the network operate in a desirable way.

Rather than imposing barriers to entry, permissionless blockchains are public and open for anyone to join. Since such networks can reasonably expect all kind of agents - including malicious actors - the key lies in incentivizing good behavior in a critical majority of the network, such that:

+ The malicious actors cannot take over the network through an escalated attack.
+ The malicious actors cannot collude to undertake an organized majority attack on the network.
+ The payoffs of securing the network are consistently higher than the cost of attacking the network.
+ The cost of attacking the network is prohibitively high.

Check [Cryptoeceonomics](https://medium.com/@cryptoeconomics/the-blockchain-economy-a-beginners-guide-to-institutional-cryptoeconomics-64bf2f2beec4).

### Ethereum - An Alternative to Bitcoin
 
> According to Ethereum's official documentation, - "Ethereum is an open blockchain platform that lets anyone build and use decentralized applications that run on blockchain technology".

The Ethereum blockchain platform facilitates scripting functionality, or 'smart contracts', which are run through the nodes in the network. As a result, unlike the Bitcoin blockchain, it does not just track transactions, it also programs them. Technically, Ethereum is a Turing-complete virtual machine with its native cryptocurrency called 'ether'. The platform was proposed in 2013 in a white paper by the then 19-year old Vitalik Buterin.

As of December 2017, Ethereum had a [market cap](https://coinmarketcap.com/coins/) of over $69 billion, making ether the second most valuable cryptocurrency after Bitcoin. 

As the second best known public blockchain after the Bitcoin blockchain, Ethereum has ushered in an era of unprecedented activity around blockchain and distributed ledger technology.

### Dapps

As [Stephan Tual](https://www.youtube.com/watch?v=Clw-qf1sUZg) explains, Ethereum applications do not have a middleman; instead, users interact in a P2P fashion with other users through a variety of interfaces - social, financial, gaming, etc. Since the applications are developed on the decentralized consensus-based network itself, third-party censorship is virtually impossible. Malicious actors cannot secretly tamper with the application by changing the code and compromise all application users (or nodes that are actively interacting with it). These _Decentralized Applications_ have come to be known as **Dapps**.

Since they are cryptographically secured, Dapps are referred to as 'secure applications'. Some of the [high profile Dapps](http://www.ethdocs.org/en/latest/introduction/web3.html) built on the Ethereum platform include:

+ **[Augur](https://augur.net/)**, which is a Decentralized Prediction Market.
+ **[Digix](https://digix.global/)**, which tokenizes gold on Ethereum.
+ **[Maker](https://makerdao.com/)**, which is a Decentralized Autonomous Organization (DAO).

The Ethereum network is a distributed global public network, which means it is not run on central servers in a certain geographical location. Instead, the computing power that runs the network is contributed by nodes that are spread across the globe. In other words, Dapps have 'zero downtime' - they never go down and, in general, cannot be switched off.

### Ethereum Smart Contracts

A hypothetical example of an Ethereum-based smart contract may involve the following transaction: in an equity raise, transfer amount X from the investor to the company upon receiving the given shares from the company. The monetary amount X, which was pre-validated by the company for the transaction (much like in a credit card purchase), is held in escrow by the smart contract, until the shares have been received by the investor. Any kind of arbitrary sophisticated business logic can be committed to the blockchain. The Ethereum blockchain only encodes these 'rules of the games'. The actual payoffs occur by interacting with the blockchain.

The illustration below describes this process. The smart contract encodes the agreement between the company raising funds and its investors (Panel 1). The smart contract sits on the Ethereum public blockchain, and is run on the Ethereum Virtual Machine (EVM). Once hitting a triggering event, like an expiration date or a strike price that has been pre-coded, the smart contract automatically executes as per the business logic (Panel 2). As an added benefit, regulators are able to scrutinize the market activity on an ongoing basis, without compromising the identity of specific players in a permissionless public blockchain, as Ethereum (Panel 3).

<img src="https://prod-edxapp.edx-cdn.org/assets/courseware/v1/bf28e4b1d1e9e3f27ad0744fd52aed9c/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Ethereum_Smart_Contracts.png" alt="Ethereum_Smart_Contracts" />

**Note**: With the advent of the Ethereum blockchain platform and the scripting functionality or smart contracts that it enables, there are ongoing attempts to do the same for the Bitcoin blockchain, which does not allow for this, due to security reasons. [RSK](http://www.rsk.co/) is one such smart contract platform that seeks to achieve this _"with a 2-way peg to Bitcoin"_. The added functionality can go a long way in making the Bitcoin blockchain useful for use cases other than cash transfers.

## Exploring Permissionless Blockchains

Let's start by examining the Bitcoin and Ethereum blockchains, both of which are permissionless, public blockchains. We will examine several large transactions, and the genesis block for each blockchain. We will look at block heights, transaction times, mining pools, timestamps, and block rewards.

### 'Certifying' a Document

We have just examined the Bitcoin and Ethereum blockchains, and the key variables to pay attention to. Next, let's examine how we can 'certify' a document on both the Bitcoin and Ethereum blockchains simultaneously, using Stamp.io, which is a certification tool. We will show you how to easily certify various types of files on Stamp.io, obtaining a 'Stampery Certificate'. We will also show you how to cross-check the hash of the transactions on the Bitcoin and the Ethereum blockchains. 

## Consensus Algorithms

Consensus in the network refers to the process of achieving agreement among the network participants as to the correct state of data on the system. Consensus leads to all nodes sharing the exact same data. A consensus algorithm, hence, does two things: it ensures that the data on the ledger is the same for all the nodes in the network, and, in turn, prevents malicious actors from manipulating the data. The consensus algorithm varies with different blockchain implementations.

While the Bitcoin blockchain uses Proof of Work as the consensus algorithm, other blockchains and distributed ledgers are deploying a variety of consensus algorithms, like the Proof of Stake, Proof of Burn, Proof of Capacity, Proof of Elapsed Time, and many others, depending on their unique requirements.

### Proof of Work (PoW)

The Proof of Work consensus algorithm involves solving a computational challenging puzzle in order to create new blocks in the Bitcoin blockchain. Colloquially, the process is known as 'mining', and the nodes in the network that engage in mining are known as 'miners'. The incentive for mining transactions lies in economic payoffs, where competing miners are rewarded with 12.5 bitcoins and a small transaction fee.

As described in the 2016 [Kudelski Security report](https://www.kudelskisecurity.com/sites/default/files/files/kudelski_Security_blockchain_20161213.pdf),

> "Proof-of-work (PoW) is the outcome of a successful mining process and, although the proof is hard to create, [it] is easy to verify."

For better understanding, please consider the following example provided by [Ofir Beigel](https://99bitcoins.com/proof-of-work-proof-of-stake/):

> "(...) guessing a combination to a lock is a proof to a challenge. It is very hard to produce this since you will need to guess many different combinations; but once produced, it is easy to validate. Just enter the combination and see if the lock opens".

Multiple criticisms exist for the PoW consensus algorithm. PoW requires a huge amount of energy to be expended, given the computationally heavy algorithm. In addition, PoW has a high latency of transaction validation, and the concentration of mining power is located in countries where electricity is cheap. In terms of the network security, PoW is susceptible to the '51% attack', which refers to an attack on a blockchain by a group of miners controlling more than 50% of the network's computing power.

### Proof of Stake (PoS)

The Proof of Stake algorithm is a generalization of the Proof of Work algorithm. In PoS, the nodes are known as the 'validators' and, rather than mining the blockchain, they validate the transactions to earn a transaction fee. There is no mining to be done, as all coins exist from day one. Simply put, nodes are randomly selected to validate blocks, and the probability of this random selection depends on the amount of stake held. So, if node X owns 2 coins and node Y owns 1 coin, node X is twice as likely to be called upon to validate a block of transactions. The specific implementation of PoS can vary, depending on the use case, or as a matter of software design. Instances include [Proof of Deposit](https://www.linkedin.com/pulse/blockchain-consensus-algorithm-proof-of-work-satyakam-chakravarty/) and [Proof of Burn](https://en.bitcoin.it/wiki/Proof_of_burn). The PoS algorithm saves expensive computational resources that are spent in mining under a PoW consensus regime.

### Proof of Elapsed Time (PoET)

Developed by Intel, the Proof of Elapsed Time consensus algorithm emulates the Bitcoin-style Proof of Work. Hyperledger's Sawtooth implementation is an example of PoET at work. Instead of competing to solve the cryptographic challenge and mine the next block, as in the Bitcoin blockchain, the PoET consensus algorithm is a hybrid of a random lottery and first-come-first-serve basis. In PoET, each validator is given a random wait time.

> "The validator with the shortest wait time for a particular transaction block is elected the leader." - [sawtooth.hyperledger.org](sawtooth.hyperledger.org)

This "leader" gets to create the next block on the chain.

### Simplified Byzantine Fault Tolerance (SBFT)

The Simplified Byzantine Fault Tolerant consensus algorithm implements an adopted version of the [Practical Byzantine Fault Tolerant](https://blog.acolyer.org/2015/05/18/practical-byzantine-fault-tolerance/) (PBFT) algorithm, and seeks to provide significant improvements over Bitcoin's Proof of Work consensus protocol. The basic idea involves a single validator who bundles proposed transactions and forms a new block. Note that, unlike the Bitcoin blockchain, the validator is a known party, given the permissioned nature of the ledger. Consensus is achieved as a result of a minimum number of _other nodes_ in the network ratifying the new block. In order to be tolerant of a Byzantine fault, the number of nodes that must reach consensus is **2_f_+1** in a system containing **3_f_+1** nodes, where **_f_** is the number of faults in the system. For example, if we have 7 nodes in the system, then 5 of those nodes must agree if 2 of the nodes are acting in a faulty manner.

The practical example would be that of [ByzCoin](http://hackingdistributed.com/2016/08/04/byzcoin/), which seeks to make key improvements over the original Bitcoin protocol. Addressing the challenge around scalability due to high latency, ByzCoin transactions are irreversibly committed to the blockchain within seconds. The added advantage is the communication trees to _"(...) optimize transaction commitments and verification under normal operations_." ([2016 Kudelski Security report](https://www.kudelskisecurity.com/sites/default/files/files/kudelski_Security_blockchain_20161213.pdf)).

### Proof of Authority (PoA)

Proof-of-Authority (PoA) is a consensus algorithm which can be used for permissioned ledgers. It uses a set of 'authorities', which are designated nodes that are allowed to create new blocks and secure the ledger. Ledgers using PoA require sign-off by a majority of authorities in order for a block to be created.

### Comparing Permissioned Consensus Approaches and Standard PoW

[Consensus](https://www.hyperledger.org/wp-content/uploads/2017/08/HyperLedger_Arch_WG_Paper_1_Consensus.pdf) can be implemented in different ways, such as through the use of lottery-based algorithms (PoET or PoW), or through the use of voting-based methods (SBFT), each targeting different network requirements and fault tolerance models.

Lottery-based algorithms are advantageous in that they can scale to a large number of nodes. Voting-based algorithms provide low-latency finality.

The following table offers an at-a-glance view of the main considerations and pros and cons of different business blockchain approaches to reaching consensus.

||Permissioned <br/> Lottery-Based | Permissioned <br/> Voting-Based| Standard Proof of Work (Bitcoin)|
|-|-|-|-|
|Speed| \*\*\*\*\* <br/> GOOD | \*\*\*\*\* <br/> GOOD | * <br/>  POOR|
|Scalability | \*\*\*\*\* <br/> GOOD | \*\*\* <br/> MODERATE | \*\*\*\*\* <br/> GOOD|
|Finality | \*\*\*  <br/> MODERATE| \*\*\*\*\* <br/> GOOD | * <br/> POOR|

## Hyperledger

Hyperledger is an open source effort created to advance cross-industry blockchain technologies. Hosted by The Linux Foundation, it is a global collaboration of members from various industries and organizations. Hyperledger boasts a host of enterprise-ready solutions. Hyperledger is about communities of software developers building blockchain frameworks and platforms. We will take a closer look at some of the current Hyperledger projects in the coming chapters.

### Hyperledger Blockchains: Permissioned or Permissionless?

Hyperledger blockchains are generally permissioned blockchains, which means that the parties that join the network are authenticated and authorized to participate on the network. Hyperledger’s main goal is to create enterprise grade, open source, distributed ledger frameworks and code bases to support business use cases.

### Advantages of Using a Permissioned Blockchain over a Permissionless Blockchain

If you look at permissionless blockchains, like the Bitcoin blockchain or the Ethereum blockchain, anyone can join the network, as well as write and read transactions. The actors in the system are not known, which means there could be some malicious actors within the network.

Hyperledger reduces these security risks and ensures that only the parties that want to transact are the ones that are part of the transaction and, rather than displaying the record of the transactions to the whole network, they remain visible only to the parties involved. So, Hyperledger provides all the capabilities of the blockchain architecture - 
    + data privacy
    + information sharing
    + immutability
    + with a full stack of security protocols 
all for the enterprise.

## Other Open Source Permissioned Distributed Ledgers

### [Chain Core](https://chain.com/technology/)

Chain Core is an enterprise permissioned blockchain system that is mostly focused on financial services, like currencies, securities, derivatives, gift cards, and loyalty points. The company partners with clients to launch and operate a network under the client's brand. Thanks to its strategic partnerships with companies such as Capital One, Citigroup, Fiserv, Nasdaq, Orange, Visa, etc., the company raised over $40 million in funding since 2014.

Within the Chain Core network, the creation and transfer of assets is decentralized. However, as stated in the 2016 Kudelski Security report,

> "the operation of the network is governed by a designated set of entities known as a federation".

The platform features the Chain Testnet, which allows decentralized application development on Chain Core, operated by Chain, Microsoft, and the Initiative for Cryptocurrencies and Contracts (IC3).

### [Corda](https://www.corda.net/)

As of September 2017, R3 is a consortium of over one hundred large global financial institutions, that seeks to leverage distributed ledger technologies to record, manage, and automate legal agreements between businesses through its software solution, called Corda.

Corda is a distributed ledger platform, which features a blockchain-style P2P network; however, it is not a blockchain platform. Unlike blockchains, which involve global availability of data across the network and third party validators, Corda only allows information access and validation functions to parties actually involved in the transaction. Featuring a different software architecture, "Corda achieves consensus between firms at the level of individual deals, not the level of the system" ([Richard Gendal Brown](http://www.r3cev.com/blog/2016/4/4/introducing-r3-corda-a-distributed-ledger-designed-for-financial-services), 2016), while supporting a variety of consensus mechanisms.

### Quorum

Created by JPMorgan, Quorum is, in fact, a fork of the Ethereum public blockchain, which uses a voting-based consensus algorithm to facilitate an enterprise-focused distributed ledger and smart contract platform. Data privacy is achieved within the network by allowing data visibility on a need-to-know basis. The platform is designed to support _"both transaction-level privacy and network-wide transparency"_ ([jpmorgan.com](https://www.jpmorgan.com/country/US/EN/Quorum)). The network validates all smart contracts and overall system state through the involvement of all running nodes. As with other permissioned ledgers, regulatory compliance is front and center in the Quorum platform.

### IOTA

The cryptocurrency IOTA has been around since 2015. According to [Martin Rosulek](https://medium.com/@MartinRosulek/how-iota-makes-future-for-internet-of-things-af14fd77d2a3), _"It is the first cryptocurrency that provides the whole ecosystem based on blockless blockchain"_ to enable machine-to-machine (M2M) transactions.

IOTA, however, is more than just a cryptocurrency. Essentially, the platform entails a generalization of the blockchain protocol (the technology called Tangle) that sits at the backend of the IOTA platform. 

Instead of paying miners to validate the transactions, the architecture of the network involves peer-based validation. We can think of a simple analogy, that of a teacher grading students' homework: the students are the clients/users in the Bitcoin protocol, and the teacher is the miner/validator. Tangle technology asks students (users) to grade each other's homework, making the need for a teacher (external validator) redundant, and avoiding expenses related to the teacher's/validator's work. This allows the platform to be completely free of cost, without facing the scaling challenges that are inherent in the first generation of blockchains.

> Additionally, the use of the platform with connected devices or the Internet of Things _"enables companies to explore new business-to-business models by making every technological resource a potential service to be traded on an open market in real time, with no fees"._  - [Roger Aitken](https://www.forbes.com/sites/rogeraitken/2017/06/15/iotas-bitfinex-listing-surges-to-1-5b-record-breaking-crypto-capitalization-on-market-debut/#7e4170e275a5), 2017

## Challenges in the Adoption/Deployment of Distributed Ledger Technologies

There are a number of challenges to the widespread use of permissioned distributed ledger technologies. Key among them are challenges around the lack of standards, regulatory challenges, and the lack of knowledge about distributed ledger technologies. These challenges are inherent to any new technological infrastructure that replaces an older infrastructure.

We hope you go on to address some of these challenges and contribute to building a secure digital future!

### Standards

Since we are still witnessing the early days of blockchain technology, there is no agreement on standards in the developer and business community, as of yet. Standards are key in ensuring interoperability and avoiding risks associated with a fragmented ecosystem. Standards are critical not just for the distributed ledger itself, but also for supporting services, like identity, privacy, and data governance. Furthermore, the management of keys, as well as protocols and standards around key loss and theft, will be critical ([Deshpande, Stewart, Lepetit, & Gunashekar](https://www.bsigroup.com/PageFiles/508003/BSI_Blockchain_DLT_Web.pdf), 2017).

As a result, the International Organization for Standardization for Blockchain and Distributed Ledger Technologies was established in 2016 and has defined areas for future standardization work ([Clare Naden](https://www.iso.org/news/Ref2188.htm), 2017). More about the ISO/TC 307 technical committee can be found at [https://www.iso.org/committee/6266604.html](https://www.iso.org/committee/6266604.html).

<img src="https://prod-edxapp.edx-cdn.org/assets/courseware/v1/f2d07a42c7ad9fce94923c44ed330a5a/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/STANDARDS_ROLE_IN_SUPPORTING_BLOCKCHAIN_AND_DLT.png" alt="STANDARDS_ROLE_IN_SUPPORTING_BLOCKCHAIN_AND_DLT" />

### Regulation

The lack of regulation around transactions on the blockchain creates an environment of uncertainty for all players. Highly regulated industries like financial services are treading carefully in the DLT space. The Securities and Exchange Commission of the United States has recently clarified its stance ([sec.gov](https://www.sec.gov/oiea/investor-alerts-and-bulletins/ib_coinofferings)) on Initial Coin Offerings (ICOs). The Chinese government has, in fact, banned all ICOs, while 60 major ICO platforms are being investigated ([Saheli Roy Choudhury](https://www.cnbc.com/2017/09/04/chinese-icos-china-bans-fundraising-through-initial-coin-offerings-report-says.html), 2017).

Similarly, there are no regulatory guidelines governing smart contracts, causing much anxiety among various players like lawyers, regulators, programmers, and businesses. The lack of regulatory guidelines, along with a lack of industry standards, exacerbates hindrances to rapid adoption of DLT.

### Lack of Know-How

The lack of know-how (and know-whom and know-where) around distributed ledger technologies and the availability of experts in the area is a major challenge in the adoption of distributed ledger technologies. While there has been an exponential increase in the interest around 'blockchain', as indicated in the figure below, there is a huge lag of technical talent in the space. In fact, the origin of this course stems from the need to address this gap in know-how, both for the business and technical audiences.

## Conclusions

For a new technology to realize its full potential, a lot of pieces need to exist before network effects can be realized. Moreover, in order for the technology to bring in systemic efficiencies, a critical mass needs to be attained. As an infrastructure technology, all major players in the market need to collaborate to define standards in a democratic manner. The blockchain community is indeed witnessing unprecedented levels of industry collaboration between players who are otherwise competitors in the space. Because of the cost of moving from one infrastructure technology to the next, an open source collaborative approach is the most promising way forward. As you will learn in Chapter 2, Introduction to Hyperledger, Hyperledger's mandate is to develop and nurture this ecosystem to develop the future of business blockchain technologies.

# Chapter 2. Introduction to Hyperledger

## Introduction & Learning Objectives

This chapter provides an overview of Hyperledger, a collaborative project hosted by The Linux Foundation that is focused on business blockchain technologies. It also introduces the current Hyperledger frameworks and modules, as of October 2017.

### Learning Objectives

+ Explain the differences between Hyperledger and permisionless blockchain technologies.
+ Discuss how Hyperledger leverages open standards and open governance to support business solutions.
+ Discuss Hyperledger frameworks (Iroha, Sawtooth, Fabric, Indy, and Burrow) and modules (Cello, Explorer, and Composer).

## Hyperledger

### Hyperledger

Hyperledger is a group of open source projects focused around cross-industry distributed ledger technologies. Hosted by The Linux Foundation, collaborators include industry leaders in technology, finance, banking, supply chain management, manufacturing, and IoT.

As of October 2017, Hyperledger consists of eight projects, five of which are distributed ledger frameworks. The other three projects are modules that support these frameworks.

![Hyperledger Modular Umbrella Approach](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/7adde90b7e1bca2dd7ac50e437291be0/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/modular_umbrella.jpg)

> As [Arnaud Le Hors](https://www.hyperledger.org/blog/2017/09/12/3431), member of the Hyperledger Technical Steering Committee, emphasized, _"these projects show how broadly applicable blockchain technology really is. This goes way beyond cryptocurrencies"_.

[Hyperledger](https://www.hyperledger.org/about) provides an alternative to the cryptocurrency-based blockchain model, and focuses on developing blockchain frameworks and modules to support global enterprise solutions. The focus of Hyperledger is to provide a transparent and collaborative approach to blockchain development.

### Comparing Hyperledger with Bitcoin and Ethereum

The following table explores the differences between Hyperledger's permissioned distributed ledgers and the Bitcoin and Ethereum permissionless blockchains. If you are considering blockchain solutions for your business requirements, it is important to pay attention to all these elements and weigh in on those that are most important for your use case.

||Bitcoin|Ethereum|Hyperledger Frameworks|
|-|-|-|-|
|Cryptocurrency based|Yes|Yes|No|
|Permissioned|No|No|Yes (in general)* |
|Pseudo-anonymous|Yes|No|No|
|Auditable|Yes|Yes|Yes|
|Immutable ledger|Yes|Yes|Yes|
|Modularity|No|No|Yes|
|Smart contracts|No|Yes|Yes|
|Consensus protocol|PoW|PoW|Various** |

*Sawtooth can be configured to be permissionless

**Key Hyperledger consensus protocols are Apache Kafka in Hyperledger Fabric, PoET in Hyperledger Sawtooth, RBFT in Hyperledger Indy, Tendermint in Hyperledger Burrow, and Yet Another Consensus (YAC) in Hyperledger Iroha. For more details, see the [Hyperledger Architecture, Volume 1](https://www.hyperledger.org/wp-content/uploads/2017/08/HyperLedger_Arch_WG_Paper_1_Consensus.pdf) paper.

### Hyperledger Goals

Hyperledger has taken a leadership role to develop cross-industry standards and provide a neutral space for software collaboration. The financial services industry, in particular, is witnessing an unprecedented level of collaboration between institutions that have traditionally been competitors. The advent of a new foundational or infrastructural technology like the blockchain - much like the Internet - requires collaboration of various actors in order to realize the full benefits of the technology. Unless all actors use a certain standard, the pace of technological dissemination will continue to be slow. Technological adoption is characterized by network effects, where the costs decrease with the increase in use of a certain technology. Since shifting to distributed ledger technology involves significant costs, open source software, communities and ecosystems that develop around these have a significant part to play.

![Hyperledger Goals](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/91890fc035a1199d4480f76b6fc743eb/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Hyperledger_Goals.jpg)

### Open Standards

> "Only an Open Source, collaborative software development approach can ensure the transparency, longevity, interoperability and support required to bring blockchain technologies forward to mainstream commercial adoption. That is what Hyperledger is about - communities of software developers building blockchain frameworks and platforms." - [hyperledger.org](https://www.hyperledger.org/about)

As we learned in _Chapter 1: Discovering Blockchain Technologies_, the non-availability of standards in distributed ledger technologies is one of the major hurdles in scaling them. One of Hyperledger's key goals is to facilitate the process of standards formation, not by promoting its own distributed ledger(s), but by providing a space for a variety of standards to co-exist simultaneously:

> "Rather than declaring a single blockchain standard, it encourages a collaborative approach to developing blockchain technologies via a community process, with intellectual property rights that encourage open development and the adoption of key standards over time." - [hyperledger-fabric.readthedocs.io](https://hyperledger-fabric.readthedocs.io/en/latest/)

> Hyperledger aims to adhere to '**open standards**', which means they are "(...) interoperable through open published interfaces and services." - John Palfreyman, [ibm.com](https://www.ibm.com/blogs/insights-on-business/government/open-innovation-blockchain-hyperledger/)

### Open Source and Open Governance

> "Today, most people understand the concept of **Open Source**. What many people don't get, and something we here at Hyperledger and The Linux Foundation pride ourselves on doing well, is **Open Governance**_." [hyperledger.org](https://hyperledger.org/blog/2017/09/06/abcs-of-open-governance)

Open source software is software that is made freely available and may be redistributed and modified. In other words, anyone has the ability to view the code, use the code, copy the code, change the code, and, depending on the open source license, contribute back changes.

Open governance means that technical decisions for an open source project are made by a group of community-elected developers drawn from a pool of active participants. These decisions include things such as which features to add, how, and when to add them.

Learn more about the specifics of Hyperledger's open governance at [https://hyperledger.org/blog/2017/09/06/abcs-of-open-governance](https://hyperledger.org/blog/2017/09/06/abcs-of-open-governance).

### Blockchain for Business

The cryptocurrency-based blockchain model, popularized by public blockchains like Bitcoin and Ethereum, currently falls short of fulfilling a host of requirements that many types of organizations would have to fulfill in order to be compliant when using blockchain and distributed ledger technologies - for instance, in the areas of financial services, healthcare, and government.

Hyperledger is a unique platform that is developing permissioned distributed ledger frameworks specifically designed for enterprises, including those in industries with strong compliance requirements. Enterprise use cases require capabilities such as scalability and throughput, built-in or interoperable identity modules for the parties involved in a transaction or a network, or even access to regulators who can access all data in the ledger as read-only to ensure compliance. The latter is particularly important because, regardless of the innovation, it has to operate within the current regulatory framework, as well as comply with any new rules that come into place specifically targeted at blockchain technologies.

The enterprise continues to be at the heart of this course.

## Hyperledger Frameworks

### Components of Hyperledger Frameworks

Hyperledger business blockchain frameworks are used to build enterprise blockchains for a consortium of organizations. They are different than public ledgers like the Bitcoin blockchain and Ethereum. The Hyperledger frameworks include:

*   An append-only distributed **ledger**
*   A **consensus algorithm** for agreeing to changes in the ledger
*   **Privacy** of transactions through permissioned access
*   **Smart contracts** to process transaction requests.

![Components of blockchain](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/0747265232da64643d21679294cbbe19/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Components_of_blockchain.jpg)

Now, let's explore the five Hyperledger frameworks (as of October 2017)!

### Hyperledger Iroha v0.95

[Hyperledger Iroha](https://hyperledger.org/projects/iroha) is a blockchain framework contributed by Soramitsu, Hitachi, NTT Data, and Colu. Hyperledger Iroha is designed to be simple and easy to incorporate into infrastructure projects requiring distributed ledger technology. Hyperledger Iroha emphasizes mobile application development with client libraries for Android and iOS, making it distinct from other Hyperledger frameworks. Inspired by Hyperledger Fabric, Hyperledger Iroha seeks to complement Hyperledger Fabric and Hyperledger Sawtooth, while providing a development environment for C++ developers to contribute to Hyperledger.

In conclusion, Hyperledger Iroha features a simple construction, modern, domain-driven C++ design, along with the consensus algorithm [YAC](https://www.overleaf.com/read/wzhwjzbjvrzn#/40115559/).

### Hyperledger Sawtooth v0.8

[Hyperledger Sawtooth](https://www.hyperledger.org/projects/sawtooth), contributed by Intel, is a blockchain framework that utilizes a modular platform for building, deploying, and running distributed ledgers. Distributed ledger solutions built with Hyperledger Sawtooth can utilize various consensus algorithms based on the size of the network. By default, it uses the Proof of Elapsed Time (PoET) consensus algorithm, which provides the scalability of the Bitcoin blockchain without the high energy consumption. PoET allows for a highly scalable network of validator nodes. Hyperledger Sawtooth is designed for versatility, with support for both permissioned and permissionless deployments.

### Hyperledger Fabric v1.0

[Hyperledger Fabric](https://www.hyperledger.org/projects/fabric) was the first proposal for a codebase, combining previous work done by Digital Asset Holdings, Blockstream's libconsensus, and IBM's OpenBlockchain. Hyperledger Fabric provides a modular architecture, which allows components such as consensus and membership services to be plug-and-play. Hyperledger Fabric is revolutionary in allowing entities to conduct confidential transactions without passing information through a central authority. This is accomplished through different channels that run within the network, as well as the division of labor that characterizes the different nodes within the network. Lastly, it is important to remember that, unlike Bitcoin, which is a public chain, Hyperledger Fabric supports permissioned deployments.

> _"If you have a large blockchain network and you want to share data with only certain parties, you can create a private channel with just those participants. It is the most distinctive thing about Fabric right now_._" _Brian Behlendorf, Executive Director of Hyperledger, The Linux Foundation_

### Hyperledger Indy

[Hyperledger Indy](https://www.hyperledger.org/projects) is a distributed ledger purpose-built for decentralized identity. Hyperledger Indy's goal is to achieve this by developing a set of

> _"(...) decentralized identity specs and artifacts that are independent of any particular ledger and will enable **interoperability** across any DLT that supports them."_

Contributed by the Sovrin Foundation, Hyperledger Indy allows individuals to manage and control their digital identities. Rather than having businesses store huge amounts of personal data of individuals, Hyperledger Indy allows businesses to store pointers to identity. Once the company verifies the other party's identity, it throws it away.

> According to Brian Behlendorf, _"(...) identity is a toxic asset that could present a liability to organizations."_

Indeed, since 2013, over 9 billion data records were lost or stolen. What is striking is that, out of these, only 4% were encrypted, and hence, rendered useless after being stolen (also called 'secure breaches'). You can find detailed statistics at [http://breachlevelindex.com/](http://breachlevelindex.com/).

One of the key principles of Hyperledger Indy is its '[Privacy by Design](https://en.wikipedia.org/wiki/Privacy_by_design)' approach. Given the immutable nature of the DLT, it is all the more important that digital identities be handled with the utmost care, keeping human values front and center.

> _"Hyperledger Indy lets users authenticate identity based on the attributes they are willing to store and share themselves. This can reduce the amount of liability contained within a business because the data can be kept with the user and presented to you again in a way that you can trust and validate that what has been said really was said and is trusted by the other parties you do business with."   -Nathan George, Maintainer, Hyperledger Indy_

Further information about the history of the project can be found at [https://sovrin.org/](https://sovrin.org/).

### Hyperledger Burrow v0.16.1

Formally known as eris-db, [Hyperledger Burrow](https://www.hyperledger.org/projects/hyperledger-burrow) was released in December 2014. Currently under incubation, Hyperledger Burrow is a permissionable smart contract machine that provides a modular blockchain client with a permissioned smart contract interpreter built- in part to the specification of the Ethereum Virtual Machine (EVM). It is the only available Apache-licensed EVM implementation.

Following are the major components of Burrow:

*   The **Gateway** provides interfaces for systems integration and user interfaces
*   The **Smart contract application engine** facilitates integration of complex business logic
*   The **Consensus Engine** serves the dual purpose of:  
    a. Maintaining the networking stack between the nodes, and,  
    b. Ordering transactions
*   The **Application Blockchain Interface** (ABCI) provides interface specification for the consensus engine and smart contract application engine to connect.

You can learn more about Hyperledger Burrow at [https://monax.io/platform/db/](https://monax.io/platform/db/).

## Hyperledger Modules

The Hyperledger frameworks which we examined in the previous section are used to build blockchains and distributed ledgers. The Hyperledger modules, which we will look at next, are auxiliary softwares used for things like deploying and maintaining blockchains, examining the data on the ledgers, as well as tools to design, prototype, and extend blockchain networks.

### Hyperledger Cello

For businesses that want to deploy Blockchain-as-a-Service, [Hyperledger Cello](https://www.hyperledger.org/projects/cello) provides a toolkit that fulfills this need. Particularly for lean businesses and small enterprises, who want to reduce or eliminate the effort required in creating, managing, and terminating blockchains, Hyperledger Cello allows blockchains deployment to the cloud. Operators can create and manage such blockchains through a dashboard, and users (typically, chaincode developers) can obtain a blockchain instance immediately.

As a Hyperledger module, _"Cello aims to bring the on-demand 'as-a-service' deployment model to the blockchain ecosystem"_, thus helping in furthering the development and deployment of Hyperledger's frameworks. Hyperledger Cello was initially contributed by IBM, with sponsors from Soramitsu, Huawei, and Intel.

Application developers and system administrators using Cello can provision and maintain Hyperledger networks. For instance, you can create a group of distributed ledger networks in virtual clouds known as 'container clusters', and then, manage and monitor those networks with a configurable dashboard. Additionally, you can build a Blockchain-as-a-Service (BaaS) platform.

![Hyperledger Cello](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/a962f1ae98ce3d4796f6d9f315b49572/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/cello.jpg)

Hyperledger Cello (Source: [https://www.hyperledger.org/blog/2017/01/17/hyperledger-says-hello-to-cello](https://www.hyperledger.org/blog/2017/01/17/hyperledger-says-hello-to-cello))

### Hyperledger Explorer

[Hyperledger Explorer](https://www.hyperledger.org/projects/explorer) is a tool for visualizing blockchain operations. It is the first ever blockchain explorer for permissioned ledgers, allowing anyone to explore the distributed ledger projects being created by Hyperledger's members from the inside, without compromising their privacy. The project was contributed by DTCC, Intel, and IBM.

Designed to create a user-friendly web application, Hyperledger Explorer can view, invoke, deploy, or query:

*   Blocks
*   Transactions and associated data
*   Network information (name, status, list of nodes)
*   Smart contracts (chain codes and transaction families)
*   Other relevant information stored in the ledger.

The ability to visualize data is of critical importance, in order to extract business value from it. Hyperledger Explorer provides this much needed functionality. Key components include a web server, a web UI, web sockets, a database, a security repository, and a blockchain implementation.

### Hyperledger Composer

[Hyperledger Composer](https://www.hyperledger.org/projects/composer) provides a suite of tools for building blockchain business networks. These tools allow you to:

*   Model your business blockchain network
*   Generate REST APIs for interacting with your blockchain network
*   Generate a skeleton Angular application.

Built in Javascript, Hyperledger Composer provides an easy-to-use set of components that developers can quickly learn and implement. The project was contributed by Oxchains and IBM.

### Hyperledger Composer (Continued)

Hyperledger Composer has created a modelling language that allows you to define the assets, participants, and transactions that make up your business network using business vocabulary. In addition, the transaction logic is then written by developers using Javascript. This simple interface allows business people and technologists to work together on defining their business network.

The [benefits](https://www.hyperledger.org/wp-content/uploads/2017/05/Hyperledger-Composer-Overview.pdf) of Hyperledger Composer are:

*   **Faster creation of blockchain applications**, eliminating the massive effort required to build blockchain applications from scratch
*   **Reduced risk** with well-tested, efficient design that aligns understanding across business and technical analysts
*   **Greater flexibility** as the higher-level abstractions make it far simpler to iterate.

You can watch an introduction to Hyperledger Composer [here](https://www.youtube.com/watch?v=cNvOQp8r0xo ).

# Chapter 3. The Promise of Business Blockchain Technologies
    
## Introduction & Learning Objectives

### Learning Objectives

*   Examine several use cases where blockchain technology is actively used to solve real world business problems.
*   Discover the factors to look at when evaluating if blockchain technology is right for a particular project.
*   Decide when to use and when not to use blockchain technology.

## Existing Blockchain Use Cases

### Business Blockchain Technologies Overview

Blockchain is a new data structure with an automated way to enforce trust among participants. Consensus algorithms ensure that all participants agree on the data stored within the blockchain. Blockchain opens the door to disrupt any industry that relies on a central authority to confirm authenticity. It also allows independent, and even competing organizations, to share information to gain efficiencies across an industry.

In permissioned blockchains, a consortium of organizations are responsible for authenticating and controlling the participants in a blockchain. In public blockchains, no central authority or administration is required to exchange data. Blockchains can drive business innovation through controlled data-sharing networks for industry consortiums.

The promise of distributed ledger technologies (DLT) to simplify and automate key work functions has many industries taking notice. Businesses recognize the efficiency gains from transitioning from closed and proprietary solutions to standard open source capabilities, such as Hyperledger business blockchain technologies. Several common project features of blockchain applications are taking shape as the technology matures.

How exactly are businesses using these emerging technologies today? Next, we will explore the state of distributed ledger technologies in actual corporate settings, and how they compare against traditional tools. 

### Supply Chain Management

Supply chain management is an important piece of enterprise resource planning (ERP). Supply chain management is the oversight of funds, raw materials, components, and finished products, as they move from suppliers, to manufacturers, to wholesalers, to retailers, to consumers. This movement can occur both within one company, or among several companies. As assumptions change over time, the supply chain models can begin to show weak performance metrics. Good supply chain management will keep product quality consistent, and also prevent either understocking or overstocking of inventory.

Stocking the right amount of inventory over time is also known as supply demand synchronization, and is the key component in just-in-time lean manufacturing and distribution. Companies want to ensure that products are available when needed, but overstocking inventory is costly. Companies that overstock perishable goods must discard items. Companies that overstock non-perishable goods cannot use the money paid for those goods for other purposes until the inventory is used. Furthermore, if the price of a good drops while a company is storing excess inventory, then the company will lose money.

Currently, there are weak points in the supply chain management. These weak points occur where there are multiple ERP systems in use across organizations. Data doesn't flow well through the handshakes or interface points between systems. These weak points usually happen during transference of ownership, or change in status between two parties. Visibility is limited at the hand-off points of funds, raw materials, components, or finished products. This lack of transparency is often intentional, as companies don't want to expose their competitive advantages (e.g., an inexpensive supplier who delivers quality products on time). Additionally, a company could be cut out of a supply chain if members start transacting directly with that company’s suppliers.

Blockchains are currently being used to solve problems in supply chain management by eliminating the need for a trusted third party to certify raw materials, components, or finished products, as they travel through a supply chain. Every participant, or node, contains a copy of all transactions. This provides an audit trail of every transaction that has occurred in the system. A change would be validated or rejected by the nodes in the system. Because all participants have a copy of all past transactions in the network, any participant can detect if a product is not as advertised. Instead of examining raw materials, components, or finished products at several points in the supply chain, a record of the inspection would be available and bound to the item as it flows through the supply chain. Although a record of the transaction is public and tied to the movement of physical items across the network, specifics such as the quantity of goods, or the identity of the parties transacting, can be done pseudo-anonymously in a blockchain. Such a granular view of movement through supply chains improves resource allocation.

The trade finance industry can also leverage information visible in a supply chain blockchain. In its broadest sense, trade finance manages capital required for international trade. Trade financing has become the norm for cross border transactions, with the [World Trade Organization](https://www.wto.org/english/res_e/booksp_e/tradefinsme_e.pdf) estimating that

> _"up to 80 percent of global trade is supported by some sort of financing or credit insurance" _(2016).

An exporter needs to to mitigate the risk of non-payment, while an importer wants to mitigate the supply risk. The function of trade finance is to act as a third party to remove the payment risk and the supply risk, whilst providing the exporter with accelerated receivables, and the importer with extended credit. Institutions that provide capital during these trades can leverage the information visible in a supply chain blockchain to better evaluate companies for lending.

![Supply Chain of Tuna](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/f8b777bb4b2add9a426b97b8f2556aad/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Supply_Chain_of_Tuna.png)

Source: Nishan Degnarain (used with permission)

### Provenance

As the previous section on blockchains for supply chain management illustrated, blockchain data improves insight into products, as they move through their lifecycle. Large enterprises are not the only parties to benefit from this increased visibility. Consumers can also benefit from blockchain technology.

Provenance is a record of ownership used as a guide to authenticity or quality. Because of the overhead involved in traditional provenance records, they were only available for very large ticket items, such as works of art. With the efficiencies gained from blockchain technology, provenance records can be available for a wider range of goods. This improved information can aid consumers as they make purchasing decisions.

![Provenance Blockchain Use Case](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/deba401bb91d6751d6651dcd849cf412/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Provenance_Use_Case.jpg)

How Provenance Works (by [Project Provenance Ltd](https://www.provenance.org/), used with permission)  

How do you, as a consumer, really know that you purchased an authentic item? Why is authenticity important? Some consumers want to make sure that fair trade and fair labor standards are upheld in the products they purchase. Others want to make sure that none of their products have been tested on animals. Still, others are concerned with the use of harmful chemicals during product manufacturing. Those consumers are willing to pay a premium to make sure that they are not funding operations that are not in line with their values. Counterfeit products, however, take advantage of the higher price point a brand that upholds strict standards can command. Their margins are increased over the authentic brand because they cut corners during production.

It turns out that counterfeit products are a global problem affecting several industries. For example, the European Union Intellectual Property Office (EUIPO), in collaboration with the International Telecommunication Union (ITU), estimates that $48 billion worth of smartphone sales were lost to phoney phones in 2015 (Karen Gilchrist, [cnbc.com](https://www.cnbc.com/2017/02/28/fake-smartphone-sales-cost-global-industry-48-billion.html), 2017). Also, "_the Interprofessional Council of Bordeaux Wine estimates that 30,000 bottles of fake imported wine are sold per hour in China"_, whereby some estimate half of the wines retailing for more than $35 in China are counterfeit (Pamela Ambler, [forbes.com](https://www.forbes.com/sites/pamelaambler/2017/07/27/china-is-facing-an-epidemic-of-counterfeit-and-contraband-wine/#394d10b15843), 2017). 

n order to be certain that your product is authentic, you would need either a record of all  thetransactions for the life of the item, or a trusted third party. Trusted third parties certify the authenticity or quality of an item. They function as a new data layer between data silos, and increase costs of transactions by charging for providing data and certifying products. Some examples of such trusted third parties are the National Organic Program (USDA Organic) for produce, Fair Trade USA for human worker conditions, or the Gemological Laboratory of America (GLA) for jewelry, diamonds, and gemstones. Blockchains can serve the function of these trusted third parties by uniquely identifying products, and certifying their authenticity. Alternatively, these trusted third parties can leverage blockchains by recording their audits and inspections on blockchains. This would reduce the overhead needed  to certify products. For example, a manufacturer could prove that its sources also abide by the certification authorities’ standards if those sources are listed on blockchains as having passed all requirements. The timing of the source’s original certification and renewals could be viewed by any interested party.

As a consumer reading from a blockchain, you would be able to verify a product’s authenticity by seeing the full chain of custody for an item. Hyperledger frameworks allow consumers to view important data attached to the goods, without necessarily viewing exactly who conducted each transfer down the supply chain line. Therefore, the promise is that you will be assured that the product you are purchasing is an authentic product, without necessarily allowing the public to view your purchasing habits, all leveraging distributed ledger technology.

### Property Rights

The legal industry has begun to examine how blockchain technologies can minimize disputes around property rights. Property rights are a division of law whereby the rights and responsibilities associated with owning an asset are established. Property ownership rights may include the right to use the asset, the right to profit from the asset, the right to exclude others from using the asset, or the right to transfer the asset to others. Property ownership responsibilities may include tax liability for the asset, maintenance and repair costs, or payment for injuries caused by unsafe or defective conditions of the asset.

Ownership for a particular asset may be transferred in whole, or in part. As a result, property rights or obligations attached to a particular asset may belong to several different entities at the same time. For example, if you purchase a plot of land, you have the right to use that land. However, the usage of the land is most likely limited by the government. The right to use the land may be taken away from you by foreclosure if you do not pay property taxes. Similarly, your right to use the land is limited to permitted uses per that areas’ zoning laws. It is unlikely that you will be allowed to operate a pesticide manufacturing plant in the middle of a residential neighborhood. If you lease out the plot of land, your right to use the property is transferred to the tenant, but you are still able to sell the plot of land to another landlord while the lease is active.

Property Rights

Companies may use blockchain technologies to record ownership rights and responsibilities. Specifically, governments have put land registry records on blockchain (Laura Shin, [forbes.com](https://www.forbes.com/sites/laurashin/2016/04/21/republic-of-georgia-to-pilot-land-titling-on-blockchain-with-economist-hernando-de-soto-bitfury/#1c7a07944da3), 2016). Companies have also put intellectual property registration and ownership on blockchain ([poex.io](https://poex.io/about)). Intellectual property includes copyright, trademark, and patents. To legally protect ownership rights in these, one registers their production, or invention, or otherwise proves when the work was established, and that they are the origin of the work.

**REGISTERING PROPERTY TITLES ON A BLOCKCHAIN VIA A SMART CONTRACT** 

![This diagram shows how a property title could be registered on a blockchain via a smart contract.](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/7606d1ed26d6415a1dda083274cffdb4/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/PROPERTY_RIGHTS.jpg)

Companies with strong brand value in particular, such as the fashion industry and luxury good providers, are interested in more efficient ways to protect their intellectual property. When data is added to a blockchain, it can provide an immutable, secure, timestamped record for the creation of intellectual property, and any changes to the data can be easily detected. Blockchains establish this in a variety of ways.

A blockchain may record a hash of a document. As an example, photographers could place a hash of their unique digital photographs on the blockchain. The hash of a digital photograph will be constant so long as the photograph file has not been altered. Therefore, the blockchain can control and track the distribution of the photograph, detect the introduction of counterfeit images, and be used to resolve disputes as to who first introduced the image. By placing a hash of intellectual property documents on the blockchain, a party can publicly demonstrate data ownership, and prove the existence of certain documents at a given moment in time, without revealing the actual data. In addition to the hash, you may also choose to store the location of the file in the blockchain, which could be used for retrieval.

### Finance 

> _"Blockchain has huge potential to move the financial services industry away from messaged based models, slow reconciliation processes and inefficiency of fragmented data stores. With blockchain, financial services can move to a shared data construct, driving down costs, increasing efficiency and opening up entirely new business models." - David Treat, Accenture_

The Bitcoin blockchain was created as a _"peer-to-peer electronic cash system"_ ([Satoshi Nakamoto, Bitcoin](https://bitcoin.org/bitcoin.pdf)). Therefore, the first blockchain use case in existence was payments. However, Bitcoin proved to be quite slow to process payments, "_somewhere in the region of 7 transactions per second"_ ([Guy Brandon, due.com](https://due.com/blog/can-the-blockchain-scale/), February 2017), when compared to Visa, which _"averages around 2,000 transactions per second, with peak capacity of perhaps 50,000 transactions per second"_ ([Guy Brandon, due.com](https://due.com/blog/can-the-blockchain-scale/), February 2017). Developers are actively working to increase the throughput capacity of Bitcoin and other blockchain payment systems ([lightning.network](https://lightning.network/)). Payments, especially international payments, can be quite costly. Blockchain technologies plan to decrease the costs associated with payments, by allowing parties to interact directly, instead of transferring through an intermediary, such as a bank. In addition, having a record of all past payments is useful to auditors and regulators. Financial institutions have heavily researched blockchain payment systems because a universally recorded world state of payment information can decrease the number of payment disputes among institutions. 

The finance industry, in particular, has shown early interest in blockchain technology. R3, a fintech company that is a member of the Hyperledger consortium, has brought together more than 100 leading financial institutions to examine blockchain technology. The finance industry has already recorded business transaction agreements on blockchain. Currently, bonds, invoice financing, letter of credit transactions, and interest rate swaps governed by an ISDA master agreement have all been recorded on blockchain.

The financial industry would like to improve transaction settlement through blockchain technology by leveraging smart contract functionality for executing trades. Absent blockchain technology, a complex process known as the post-trade cycle is initiated once parties 'execute' a trade. The post-trade cycle involves a series of steps to verify the terms of a trade, and to transfer assets involved in the trade in order to effectuate and settle the trade. Some trades are currently required by law to go through a separate central clearing organization. This organization steps in as the counterparty to each trade, creating two distinct contracts for each trade. These organizations are central securities depositories, whose role is to minimize the risk of trade default, and also to enforce rules against overexposure to certain types of trades.

Although every trade has its own lifecycle, generally, the following steps will occur:

1.  Parties execute a trade. Executing a trade occurs when parties agree on the details of a trade and are willing to enter into the deal.
2.  One party will draft an inception document, capturing all the terms of the trade, and will send it to the other party to get the trade confirmed.
3.  The recipient of the inception document will check the details of the trade and confirm the trade by signing and returning the document. Confirmation communication is done often by Fax, SWIFT, or Telex.
4.  The trade is allocated. For flexibility of profit and loss booking, parties will often allocate the trade to various sub-entities within their organization.
5.  Each trade will be stored by the party who was allocated the trade on an internal database. For ease of identification, the trade is assigned a unique Trade ID as a standard identifier.
6.  Post-Trade Changes are sometimes made by the parties. This can occur when:  
    + The trade can be amended with consent of both parties  
    + One party may assign its position in the trade to a different party  
    + A partial termination of the trade may be triggered if a change in the notional of the trade that is not pre-fixed according to the agreement occurs  
    + Termination of the deal before maturity of the trade may occur, which may entail a termination fee.
7.  Payment is made. These payments may be at the close of a trade, or at intermediate stages while a trade is still open. When the payments are made on an open contract, this is known as 'revaluation' and is done to minimize the risk of nonpayment by a counterparty whose position has weakened in the trade due to events that occurred after trade execution.
8.  Audit of the trade and associated payments is performed by the parties. If a dispute occurs, the parties must communicate and come to a resolution for such discrepancies. This is a manual and costly process.

Smart contracts may greatly improve the process of post-trade settlement, by reducing disputes and errors. Smart contracts will ensure that final settlement will happen when the execution of a trade occurs. With smart contract technology, a legal agreement can automatically execute clauses within it.

![Financial services blockchain use case](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/35b80d9faa29ce372e1ae13ecacca30f/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Finance.jpg)

The image above shows the automation of back-office processes involved in trade confirmation and post-trade settlement via DLT. An asset ledger stores ownership and transactions. Smart contracts allow the asset ledger to handle collateral management and initiate payments per contract terms. Venues (e.g. exchanges, MTFs, bilateral voice conversations) still match trade requests with a counterparty, and provide price discovery. Querying information on the asset ledger may assist with price discovery. The asset ledger verifies the parties and asset ownership. It will then either accept, or reject the trade. If, for example, the seller does not own the asset in question, or the new trade would result in an illegal overexposure on the buyer side, the trade would be rejected. When a trade is valid and accepted onto the blockchain, the blockchain automates an immediate change in ownership, or a delayed, or contingent asset transfer. The changes in asset ownership or contract terms are securely recorded onto the asset ledger. The contract is programmed to execute automatically, exchanging payments and other assets per the terms agreed to by the parties.

It is still unclear whether courts will enforce blockchain contracts in the same way that they enforce traditional written contracts, with inked paper signatures. Therefore, the current best practice is to record trades on blockchain, alongside traditional legal documentation. The operative clauses in the traditional written contract are converted into smart contract templates to be placed on blockchain once a trade is confirmed. For example, a full ISDA master agreement document would be stored on blockchain, and tied to the smart contract governing the underlying swap or derivative trade. This leverages the predictable outcomes of a legal contract with the efficiencies that can be gained from distributed ledger technologies.

There are both advantages and disadvantages to controlling funds on blockchain. If funds aren’t under the control of the smart contract, then there is no way a payment can be guaranteed. If funds are controlled by the parties’ smart contract agreement, then those payments can indeed be guaranteed at the close of the trade. However, this also means that those funds cannot be used by the parties’ for anything else throughout the lifecycle of the smart contract. Today, a party may use the funds separate from the contract. This exposes the other party to the risk of nonpayment, but frees up capital for other purposes. The connection between risk and return is not a problem that blockchains can solve.

Conducting post-trade settlement in an automated way through smart contracts promises to introduce efficiencies, and reduce friction associated with trades. However, the industry has experienced some barriers to the adoption of blockchain technologies. Primarily, data privacy rules have come into conflict with the way standard blockchain protocols operate. Some regulations in the finance industry will not allow you to share information, or store it on a shared medium, even if it is encrypted. In addition, regulations covering securities professionals specify how ownership of certain assets must be recorded and properly transferred. Securities professionals include broker-dealers and investment advisers. These rules were written without the anticipation of blockchain technologies, and are at odds with the fully digital transference of assets over blockchain technologies. Either these regulations will need to adapt to blockchain technologies, or blockchain technologies will need to introduce new features conforming to existing regulations. The adoption of blockchain technologies for post-trade settlement will likely change the role of governments in the financial oversight. There will be less of a need to enforce individual trades and resolve settlement disputes, but the government may collect better data on existing trades by viewing and querying the blockchain. With this increased insight into the market, the government may or may not develop stronger standards for trades through smart contracts.

### Healthcare 

A number of multi-party processes in the healthcare industry can leverage distributed ledger technology. By streamlining these multi-party processes, the healthcare industry can reduce the time and expense of collecting and verifying multiple pieces of information in order to deliver quality care to patients. Healthcare providers and insurance companies have begun to explore how blockchain can improve the delivery of patient care.

In 2015, the US spent 27.42% of the federal budget, or $1.05 trillion, on healthcare ([National Priorities Project](https://www.nationalpriorities.org/budget-basics/federal-budget-101/spending/)). Because these costs are so high, the US government, in particular, [has invested resources](https://search.usa.gov/search?utf8=%E2%9C%93&affiliate=healthit.gov&query=blockchain&commit=Search) into healthcare blockchain technology. The [Office of National Coordinator for Health Information Technology (ONC)](https://www.healthit.gov/) is responsible for health information technology. It has recognized a need for nationwide interoperability and standards for electronic health records, claims processing, and verification of provider credentials. To that end, it has sponsored many government blockchain initiatives in healthcare.

The healthcare industry has already placed medical insurance enrollment information on blockchain for verification, and plans to incorporate many other aspects of medical insurance claims processing on blockchain. One cost borne by health insurance providers is auditing care providers. Health insurance providers must verify whether a practitioner actually delivered the care that he or she was obliged to deliver to the patient. Health insurance providers must also audit the financial aspects incurred as part of this care, to ensure that care was paid, and the charges were accurate. Tying the care auditability with the payment auditability provides a key advantage to reducing the potential for fraud.

The healthcare industry has examined placing prescription drug fulfillment processes on blockchain since they involve gathering and checking information from many sources. Insurance benefits investigation eligibility checks are performed to see if insurance will pay. Prior authorization and step therapy requirements are checked to see if a patient is able to receive a particular drug, or if other drugs are preferred. Formulary checks, patients’ assistance checks, and pharmacy stock checks must all be performed. The healthcare industry has also used DLT to handle online identity management, by uploading verified pieces of a healthcare professional’s credentials for license verification.

![The BlockRx Pharma Ecosystem - Healthcare blockchain use case](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/8c6873e099cbc51e795daa4a3917e9da/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/The_BlockRx_Pharma_Ecosystem.png)

By [The BlockRx Project](https://www.blockrx.com/), retrieved from the [Hyperledger Healthcare Working Group](https://wiki.hyperledger.org/groups/healthcare/healthcare-wg), [August 22nd, 2017 Meeting](Hyperledger Healthcare Working Group, August 22nd, 2017 Meeting)

## When to Use or Not to Use Blockchain Technologies

### When to Use Blockchain

There are certain factors to consider when evaluating blockchain distributed ledger technology for your business. How many participants are in your system? What is the geographical distribution of the participants? What sort of performance requirements do you have? Defining the rules, risks, and responsibilities of each party in your blockchain system is useful as you consider transferring a database to a decentralized environment such as one of the Hyperledger frameworks. Blockchain is best suited for business applications where one or more of the following conditions apply:

*   There is a need for a shared common database
*   The parties involved with the process have conflicting incentives, or do not have trust among participants
*   There are multiple parties involved or writers to a database
*   There are currently trusted third parties involved in the process that facilitate interactions between multiple parties who must trust the third party. This could include escrow services, data feed providers, licensing authorities, or a notary public
*   Cryptography is currently being used or should be used. Cryptography facilitates data confidentiality, data integrity, authentication, and non-repudiation
*   Data for a business process is being entered into many different databases along the lifecycle of the process. It is important that this data is consistent across all entities, and/or digitization of such a process is desired
*   There are uniform rules governing participants in the system
*   Decision making of the parties is transparent, rather than confidential
*   There is a need for an objective, immutable history or log of facts for parties’ reference
*   Transaction frequency does not exceed 10,000 transactions per second.

### When Not to Use Blockchain

Blockchain technology is a powerful tool, but it is not always the right tool for the job at hand. If you are contemplating using blockchain technology, be sure to evaluate the problem fully. The following conditions are not currently well suited to blockchain-based solutions:

#### The process involves confidential data

The biggest advantage and challenge in deploying blockchains is the radical transparency which they provide. Methods are being developed to hide confidential data on the blockchain, while sharing it only to relevant parties. Regulations for data privacy often do not allow for blockchain solutions. A thorough review of the relevant privacy rules governing your business case should be examined to see whether blockchain is appropriate. For example, is leaking data in encrypted form allowed? What level of encryption is required when transmitting data?

![Confidential data](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/9cac310a28ac75102337a8f38e2aab6d/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/security-2688911_1280.jpg)

#### The process stores a lot of static data, or the data is quite large

With blockchain technology, the entire database is stored across many nodes in a blockchain system. Because the replication factor of these systems is so high, they are best suited to databases that have many state changes, or store only the minimum necessary amount of information. If the data is relatively static, or if the files to be stored are quite large, a different technical solution may be more appropriate.

![Large Data](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/efcb50e1c438a0dde724b24614a3f14f/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/monitor-1307227_1280.jpg)

#### Rules of transactions change frequently

![Rules](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/538270ee6dffca5be32d58b154ea15ba/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/rule-1752625_1280.png)

If the rules around how your business processes are conducted change frequently, or change in unexpected ways, then blockchain may not be well suited for your use case. The rules of transactions in blockchain are often pre-set, and smart contracts do not change execution paths once they have been initiated. Everything that takes place on a blockchain must be completely deterministic. Additionally, blockchains are append-only databases. A relational database may be more suitable if you need to make many changes to your data as the rules of your transactions change.

#### The use of external services to gather/store data

A blockchain smart contract does not currently initiate the retrieval of external data. Instead, one or more trusted parties ('oracles') must create a transaction which embeds that data in the chain. This data is often gathered and stored in a traditional database by the oracle. Any interaction between a blockchain and the outside world is restricted to regular database operations.

In other words, an oracle pushes data onto the blockchain, rather than a smart contract pulling it in. Once the oracle pushes the data, every node will have an identical copy of this data. This allows for the data to be safely used in a smart contract computation. While oracles allow for blockchain interface with external data, they undermine the goal of a decentralized system. Examine when such a trusted authority should be retained. When the trusted authority would or should be retained, efficiencies in the blockchain are not as high as in other applications.

![Database receiving data from external services](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/68305034acd64f6f94e99a00e32feae2/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/database-1954920_640.jpg)

#### Simpler Alternatives

For some applications, other options are simply more efficient. When evaluating blockchain technology, consider whether regular file storage, a centralized database, or database replication with master/slave relationship between the original and copies is suitable. If those structures are suitable, then you can deploy your application with reduced complexity. Do you need a smart contract or are stored procedures written in an extension of SQL sufficient? Similarly, some applications can simply utilize cryptographic methods common in blockchains, without the database replication mechanisms of a blockchain.

![Options](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/b97f0541ebcac90a4cb03dc80ba0f805/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Options.jpg)

### Blockchain Decision Path

The following diagram provides generalized, high-level decision points about when to use or not to use blockchain technology for your business.

![Blockchain decision paths](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/66ec31bc544413fd8d830ba39d355e4f/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Blockchain_Decision_Flowchart.png)

# Chapter 4. Technical Requirements

## Introduction & Learning Objectives

### Introduction

In this section, we will discuss different prerequisites that need to be fulfilled to ensure that our system is prepared for the technical requirements of this course.

Before you proceed to chapters on Hyperledger Iroha, Hyperledger Sawtooth, and Hyperledger Fabric, you have to have the following features installed on your computer: **cURL**, **Node.js**, **npm** package manager, **Go** Language, **Docker**, and **Docker Compose,** and, if you are a Windows user,** VirtualBox**.

+ Install cURL.
+ Install Node.js and npm package manager.
+ Install Go Language.
+ Install Docker and Docker Compose.
+ Install Virtual Box (if you are a Windows user).

## Installations on Linux

### Installing cURL
+ Open a terminal window: **CTRL+ALT+T**.
+ Type the following command and enter your password: **$ sudo apt install curl**
+ To check, run the following command in your terminal/command line: **$ curl -V** (**Note**: The "V" is capitalized.)

### Installing Docker

+ Docker provides great instructions on how to install it [here](https://docs.docker.com/engine/installation/linux/docker-ce/ubuntu/).
+ The following directions will assume **64-bit Ubuntu 16.04 VPS**, since it is the simplest way to get Docker.
+ For Ubuntu, you have the choice between the Community Edition (CE) or the Enterprise Edition (EE). We recommend CE, since it is ideal for developers and small teams looking to experiment with Docker.

### Manage Docker as a Non-Root User

+ If you don't want to use **sudo** when you use the **docker** command, create a Unix group called **docker** and add users to it. When the **docker**daemon starts, it makes the ownership of the Unix socket read/writable by the **docker** group.

+ **Warning**: The **docker**group grants privileges equivalent to the **root**user. For details on how this impacts security in your system, see [Docker Daemon Attack Surface](https://docs.docker.com/engine/security/security/#docker-daemon-attack-surface).

To create the **docker** group and add your user:

1. Create the docker group: **$ sudo groupadd docker**
2. Add your user to the **docker** group: **$ sudo usermod -aG docker $USER**
3. Log out and log back in, so that your group membership is re-evaluated.
4. On a desktop Linux environment such as X Windows, log out of your session completely and then log back in.
5. Verify that you can run Docker commands without **sudo** : **$ docker run hello-world**
6. This command downloads a test image and runs it in a container. When the container runs, it prints an informational message and exits.

### Docker Compose

+ To install Docker Compose, run the following commands in your terminal/command line: **$ sudo apt update** and **$ sudo apt install docker-compose**
+ Check to make sure that you have Docker version 17.03.1-ce or greater, and Docker Compose version 1.9.0 or greater: **$ docker --version && docker-compose --version**

### Installing Node.js and npm

+ To install **Node.js** and **npm**, run the following commands in your terminal/command line:

    + $ sudo bash -c "cat >/etc/apt/sources.list.d/nodesource.list" <<EOL
    deb https://deb.nodesource.com/node_6.x xenial main
    deb-src https://deb.nodesource.com/node_6.x xenial main
    EOL
    + **$ curl -s https://deb.nodesource.com/gpgkey/nodesource.gpg.key | sudo apt-key add -**
    + **$ sudo apt update**
    + **$ sudo apt install nodejs**
    + **$ sudo apt install npm**

+ Verify the installation, as well as  the versions of both **Node.js** and npm,and make sure the **Node.js** version you are installing is greater than v6.9 (do not use v7), and the **npm** version is greater than 3.x: **$ node --version && npm --version**

### Installing Go Language

+ Visit [https://golang.org/dl/](https://golang.org/dl/) and make note of the latest stable release (**v1.8 or later**). To install Go language, run the following commands in your terminal/command line: 
    + **$ sudo apt update**
    + **$ sudo curl -O https://storage.googleapis.com/golang/go1.9.2.linux-amd64.tar.gz**
    + **$ sudo tar -xvf go1.9.2.linux-amd64.tar.gz**
    + **$ sudo mv go /usr/local**
    + **$ echo 'export PATH=$PATH:/usr/local/go/bin' >> ~/.profile**
    + **$ source ~/.profile**
+ Check that the Go version is v1.8 or later: **$ go version**

## Installations on Windows

### System Requirements

Please note you must not have Docker for Windows installed, or HyperV enabled for VirtualBox to run. See [here](http://www.poweronplatforms.com/enable-disable-hyper-v-windows-10-8/) on how to disable HyperV.

Below are the expected requirements for Ubuntu 16.04, which we will be downloading on our virtual machine:

*   2 GHz dual core processor or better
*   2 GB system memory
*   25 GB of free hard drive space
*   Either a DVD drive or a USB port for the installer media.

### Installing VirtualBox and Creating a Virtual Machine

Download and install the latest VirtualBox platform packages from [here](https://www.virtualbox.org/wiki/Downloads). Once installed, you will be greeted by a screen similar to the one presented below.

![Creating Virtual Machine](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/0660d3d8de73569ac202e1e17b8cef2f/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Windows-img1.png)

Click "New" to create a new virtual machine. At this point, you will need to choose a Linux distribution to install. Many Linux distributions will work for this tutorial, but we recommend using **Ubuntu 16.04**, which is a very popular one.

Take note of the version selected. If you are sticking with our recommendation of Ubuntu, you should select **Ubuntu (64-bit)** (if 64-bit is not available, 32-bit is fine).

For the rest of the setup, use the following options:

*   2 GHz dual core processor or better
*   2 GB system memory
*   25 GB of free hard drive space
*   Either a DVD drive or a USB port for the media installer.

### Downloading and Installing Linux

Before starting the virtual machine, you will need to install your Linux distribution. If using Ubuntu, please download the latest 16.04 desktop version [here](https://www.ubuntu.com/download/desktop). Once the image file download is complete, click "Start" to boot your virtual machine.

![Downloading and Installing Linux 1](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/6efbbe61a10fbd4be21013558beb66e3/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/windows-img2.png)

Browse for and open the image file you just downloaded, and click "Start". Follow the install prompts to install Linux.

![Downloading and Installing Linux 2](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/847b28d4458a1bfe248e35f0d4f92a1b/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/windows-img3.png)

Grab a coffee! It may take a few minutes to install. Restart when prompted.

To open a terminal, you can press **CTRL+ALT+T**, or find it by clicking the Ubuntu Home button and searching for 'terminal'. You can now browse the web, download/install any Ubuntu software and, most importantly, continue the tutorial! Good luck! For more help on VirtualBox, check out their excellent manual [here](https://www.virtualbox.org/manual/).

![Downloading and Installing Linux 3](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/7dbe25db1d6baac310dbc83cdb1ad939/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/windows-img4.png)

### Installing cURL
+ Open a terminal window: **CTRL+ALT+T**.
+ Type the following command and enter your password: **$ sudo apt install curl**
+ To check, run the following command in your terminal/command line: **$ curl -V** (**Note**: The "V" is capitalized.)

### Installing Docker

+ Docker provides great instructions on how to install it [here](https://docs.docker.com/engine/installation/linux/docker-ce/ubuntu/).
+ The following directions will assume **64-bit Ubuntu 16.04 VPS**, since it is the simplest way to get Docker.
+ For Ubuntu, you have the choice between the Community Edition (CE) or the Enterprise Edition (EE). We recommend CE, since it is ideal for developers and small teams looking to experiment with Docker.

### Manage Docker as a Non-Root User

+ If you don't want to use **sudo** when you use the **docker** command, create a Unix group called **docker** and add users to it. When the **docker**daemon starts, it makes the ownership of the Unix socket read/writable by the **docker** group.

+ **Warning**: The **docker**group grants privileges equivalent to the **root**user. For details on how this impacts security in your system, see [Docker Daemon Attack Surface](https://docs.docker.com/engine/security/security/#docker-daemon-attack-surface).

To create the **docker** group and add your user:

1. Create the docker group: **$ sudo groupadd docker**
2. Add your user to the **docker** group: **$ sudo usermod -aG docker $USER**
3. Log out and log back in, so that your group membership is re-evaluated.
4. On a desktop Linux environment such as X Windows, log out of your session completely and then log back in.
5. Verify that you can run Docker commands without **sudo** : **$ docker run hello-world**
6. This command downloads a test image and runs it in a container. When the container runs, it prints an informational message and exits.

### Docker Compose

+ To install Docker Compose, run the following commands in your terminal/command line: **$ sudo apt update** and **$ sudo apt install docker-compose**
+ Check to make sure that you have Docker version 17.03.1-ce or greater, and Docker Compose version 1.9.0 or greater: **$ docker --version && docker-compose --version**

### Installing Node.js and npm

+ To install **Node.js** and **npm**, run the following commands in your terminal/command line:

    + $ sudo bash -c "cat >/etc/apt/sources.list.d/nodesource.list" <<EOL
    deb https://deb.nodesource.com/node_6.x xenial main
    deb-src https://deb.nodesource.com/node_6.x xenial main
    EOL
    + **$ curl -s https://deb.nodesource.com/gpgkey/nodesource.gpg.key | sudo apt-key add -**
    + **$ sudo apt update**
    + **$ sudo apt install nodejs**
    + **$ sudo apt install npm**

+ Verify the installation, as well as  the versions of both **Node.js** and npm,and make sure the **Node.js** version you are installing is greater than v6.9 (do not use v7), and the **npm** version is greater than 3.x: **$ node --version && npm --version**

### Installing Go Language

+ Visit [https://golang.org/dl/](https://golang.org/dl/) and make note of the latest stable release (**v1.8 or later**). To install Go language, run the following commands in your terminal/command line: 
    + **$ sudo apt update**
    + **$ sudo curl -O https://storage.googleapis.com/golang/go1.9.2.linux-amd64.tar.gz**
    + **$ sudo tar -xvf go1.9.2.linux-amd64.tar.gz**
    + **$ sudo mv go /usr/local**
    + **$ echo 'export PATH=$PATH:/usr/local/go/bin' >> ~/.profile**
    + **$ source ~/.profile**
+ Check that the Go version is v1.8 or later: **$ go version**

# Chapter 5. Introduction to Hyperledger Iroha

## Introduction & Learning Objectives

### Learning Objectives

*   Understand the basics of Hyperledger Iroha v0.95.
*   Discuss crucial components of the Hyperledger Iroha architecture, including the consensus algorithm YAC (Yet Another Consensus), peers, clients and the ledger block storage _Ametsuchi._
*   Join the Hyperledger Iroha framework discussion and development.

## Key Components

### Hyperledger Iroha

Hyperledger Iroha is a blockchain framework, and one of the Hyperledger projects hosted by The Linux Foundation. Hyperledger Iroha was initially contributed by Soramitsu, Hitachi, NTT Data, and Colu. Hyperledger Iroha is designed to be simple and easy to incorporate into infrastructure projects requiring distributed ledger technology. Hyperledger Iroha features a simple construction, modern, domain-driven C++ design, emphasis on mobile application development, and the YAC consensus algorithm.

![Hyperledger Iroha logo](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/94f08731c2a2a792a7a20c298839aa38/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Iroha_3_sm.png)

### Architecture Overview

Before diving into the key components of Hyperledger Iroha, it is important to get an overarching look at this framework. The diagram below shows a layered architectural view of the different components that make up Hyperledger Iroha. The four layers are: API, Peer Interaction, Chain Business Logic, and Storage.

![Iroha architecture](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/cb033d180ecb4eb288f2f0a489195e6c/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Iroha-architecture.png)

The components are:

*   **Model** classes are system entities.
*   **Torii** (gate) provides the input and output interfaces for clients. It is a single [gRPC](https://grpc.io/) server that is used by clients to interact with peers through the network. The client's RPC call is non-blocking, making Torii an asynchronous server. Both commands (transactions) and queries (read access) are performed through this interface.
*   **Network** encompasses interaction with the network of peers.
*   **Consensus** is in charge of peers agreeing on chain content in the network. The consensus mechanism used by Iroha is YAC (Yet Another Consensus), which is a practical byzantine fault-tolerant algorithm based on voting for block hash.
*   **Simulator** generates a temporary snapshot of storage to validate transactions by executing them against this snapshot and forming a verified proposal, which consists only of valid transactions.
*   **Validator** classes check business rules and validity (correct format) of transactions or queries. There are two distinct types of validation that occur in Hyperledger Iroha:  
    + **Stateless validation** is a quicker form of validation, that performs schema and signature checks of the transaction.   
    + **Stateful validation** is a slower form of validation, that checks the permissions and the current world state view, which is the latest and most actual state of the chain, to see if desired business rules and policies are possible. For example, does an account have enough funds to transfer?
*   **Synchronizer** helps to synchronize new peers in the system or temporarily disconnected peers.
*   **Ametsuchi** is the ledger block storage which consists of a block index (currently Redis), block store (currently flat files), and a world state view component (currently PostgreSQL).

### Participants within the Network

There are three main participants within a Hyperledger Iroha network:

*   **Clients** are able to:  
    a. Query data that they have access/permission to  
    b. Perform a state-changing action, 'transaction', which consists of atomic operations, called 'commands'. For example, in a single transaction, a user can transfer funds to three people (three separate commands). But, if he/she does not have enough funds to cover for all, the whole transaction will be rejected.
*   **Peers** maintain the current state and their own copy of the shared ledger. A peer is a single entity in the network, and has an address, identity, and trust. Hyperledger Iroha is designed so that a single peer may be a single computer or scaled for a cluster, meaning different computers are used for ledger storage, indices, validation, and peer-to-peer logic.
*   **Ordering service** orders transactions into a known order. There are a few options for the algorithm used by the ordering service. Kafka is considered a good candidate. It is important to mention that if Kafka, or any other distributed solution is used, that it be clustered; otherwise, this will result in a single point of failure.

### Transaction Flow Basics 

**Step 1:** A client creates and sends a transaction to the **Torii** gate, which routes the transaction to a peer that is responsible for performing stateless validation.

![Step 1 of Iroha transaction flow](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/31cba94d9a190c0a12ab6bac4c891e14/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Step_1_of_Iroha_Transaction_Flow.png)

**Step 2**: After the peer performs stateless validation, the transaction is first sent to the ordering gate, which is responsible for choosing the right strategy of connection to the **ordering service**.

![Step 2 of Iroha Transaction Flow](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/21102f3a868cc94b8157d7871ca30192/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Step_2_of_Iroha_Transaction_Flow.png)

**Step 3:** The ordering service puts transactions into order and forwards them to peers in the consensus network in the form of **proposals**. A proposal is an unsigned block shared by the ordering service, that contains a batch of ordered transactions. Proposals are only forwarded when the ordering service has accumulated enough transactions, or a certain amount of time has elapsed since the last proposal. This prevents the ordering service from sending empty proposals.

![Step 3 of Iroha Transaction flow](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/dd7b06c38b34545769fb70f4e5a1a61a/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Step_3_of_Iroha_Transaction_Flow.png)

**Step 4**: Each peer verifies the proposal’s contents (_stateful validation_) in the _Simulator_ and creates a block which consists only of verified transactions. This block is then sent to the _consensus gate_ which performs YAC consensus logic.

![Step 4 of Iroha transaction flow](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/91303543f6393c61426a9b216083bed8/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Step_4_of_Iroha_transaction_flow.png)

**Step 5**: An ordered list of peers is determined, and a leader is elected based on the YAC consensus logic. Each peer casts a vote by signing and sending their proposed block to the leader.

![Step 5 of Iroha transaction flow](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/00da4d62048b9bdf0b331629946b3573/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Step_5_of_Iroha_transaction_flow.png)

**Step 6**: If the leader receives enough signed proposed blocks (i.e. more than two thirds of the peers), then it starts to send a **commit message**, indicating that this block should be applied to the chain of each peer participating in the consensus. Once the commit message has been sent, the proposed block becomes the next block in the chain of every peer via the _synchronizer_.

![Step 6 of the Iroha transaction flow](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/118a771edf63220195e924a7154eaedd/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Step_6_of_Iroha_Transaction_flow.png)

### YAC (Yet Another Consensus) - Consensus Functions

Hyperledger Iroha currently implements a consensus algorithm called **YAC** (Yet Another Consensus), which is based on voting for block hash. Consensus involves taking blocks after they have been validated, collaborating with other blocks to decide on commit, and propagating commits between peers. The YAC consensus performs two functions: ordering and consensus.

Ordering is responsible for ordering all transactions, packaging them into proposals, and sending them to peers in the network. The ordering service is an endpoint for setting an order of transactions and their broadcast (in a form of proposal). Ordering is not responsible for performing stateful validation of transactions.

**Note:** Currently, the ordering service is a single point of failure that does the ordering, and, therefore, Hyperledger Iroha is neither crash fault-tolerant, nor byzantine fault-tolerant.

+ Consensus is responsible for agreement on blocks based on the same proposal.
+ Validation is an important part of the transaction flow, however it is separate from the consensus process.

### YAC - Steps to Successful Consensus

**Step 1**: The ordering service shares a proposal to all peers. A **proposal** is an unsigned block created and shared to peers in the network by the ordering service. It contains a batch of ordered transactions.

**Step 2**: Peers calculate the hash of a verified proposal and sign it. The resulting **<Hash, Signature>** tupleis called a **vote**.

**Step 3**: Based on the hashes created in the previous step, each peer computes an ordering list or order of peers. To do this, the ordering function will need to have knowledge of all the peers voting in the network, and is based on the hash of the proposed block. The first peer in the list is called the **leader**. The leader is responsible for collecting votes from other peers and sending the commit message.

**Step 4**: Each peer votes. The leader collects all the votes and determines the supermajority of votes for a certain hash. The leader sends a commit message that contains the votes of the committing block. This response is called a **commit**.

**Step 5**: After receiving the commit, the peers verify the commit and apply the block to the ledger. At this point, consensus is complete.

### YAC - Failure to Reach Consensus

We have just covered the steps needed to reach successful consensus, but there are also points in which failure may occur. Next, we will cover a couple of the failure cases: broken leader and bad transactions from the ordering service.

In the case of a broken leader, the leader may act unfairly in the collection of votes, or it takes the leader too long to respond with a commit. In such situations, other peers set a time for receiving a commit message from the leader. If the timer expires, the next peer in the order list becomes the new leader.

In the case of bad transactions from the ordering service, the ordering service may forward transactions that do not pass stateless validation. To rectify this, peers should remove those transactions from the proposal, and further compute the hash from the rest of the transactions in the proposal.

### Mobile Libraries

One of the most defining characteristics of Hyperledger Iroha is its focus on providing mobile libraries.

A major goal with Hyperledger Iroha is creating a distributed ledger system that can be easily utilized by applications. In order to accomplish this, Hyperledger Iroha offers open source software libraries for **iOS**, **Android**, and **Javascript**. These libraries allow for simple compatibility with not only Hyperledger Iroha, but also, potentially, with other networks through flexible API functions.

If you would like to take a look, these libraries are all open source, and available on Github:

*   Android: [https://github.com/hyperledger/iroha-android](https://github.com/hyperledger/iroha-android)
*   iOS: [https://github.com/hyperledger/iroha-ios](https://github.com/hyperledger/iroha-ios).

### Relationship to Hyperledger Fabric and Hyperledger Sawtooth

One of the main goals at Hyperledger in the future is to have less disjointed projects, and more libraries that can be used together as components. With that vision in mind, Hyperledger Iroha wants to eventually provide the following C++ components that can be used by other Hyperledger projects:

*   YAC consensus library
*   Ed25519 digital signature library
*   SHA-3 hashing library
*   Iroha transaction serialization library
*   P2P communication library
*   iOS library
*   Android library
*   JavaScript library
*   Blockchain explorer/data visualization suite.

### Joining the Hyperledger Iroha Community on GitHub

Hyperledger Iroha is an open source project where ideas and code can be publicly discussed, created, and reviewed. There are many ways to join the Hyperledger Iroha community, and we will share with you some of the ways to get involved, either from a technical standpoint, or from an ideas/issues creation perspective.

You can get involved with the Hyperledger Iroha community on GitHub. All code available on GitHub is forkable and viewable:

*   [https://github.com/hyperledger/iroha](https://github.com/hyperledger/iroha)
*   [https://github.com/hyperledger/iroha-ios](https://github.com/hyperledger/iroha-ios)
*   [https://github.com/hyperledger/iroha-android](https://github.com/hyperledger/iroha-android)
*   [https://github.com/hyperledger/iroha-javascript](https://github.com/hyperledger/iroha-javascript)
*   [https://github.com/hyperledger/iroha-python](https://github.com/hyperledger/iroha-python)
*   [https://github.com/hyperledger/iroha-scala](https://github.com/hyperledger/iroha-scala)
*   [https://github.com/hyperledger/iroha-dotnet](https://github.com/hyperledger/iroha-dotnet)
*   [https://github.com/hyperledger/iroha-api](https://github.com/hyperledger/iroha-api).

### Joining the Hyperledger Iroha Community via Rocket.Chat and Mailing Lists

You can join the live conversations on Rocket.Chat (which is an alternative to Slack), using your Linux Foundation ID:

*   [https://chat.hyperledger.org/channel/iroha](https://chat.hyperledger.org/channel/iroha)
*   [https://chat.hyperledger.org/channel/iroha-smartcontracts](https://chat.hyperledger.org/channel/iroha-smartcontracts).

Another option is to join the mailing list(s) for technical discussions and announcements: [https://lists.hyperledger.org/mailman/listinfo/hyperledger-iroha](https://lists.hyperledger.org/mailman/listinfo/hyperledger-iroha).

### Iroha API Documentation

The Hyperledger Iroha team has been actively working on creating API documents. If you are interested in taking a look and testing for yourself, you can visit [https://hyperledger.github.io/iroha-api/#overview](https://hyperledger.github.io/iroha-api/#overview).

# Chapter 6. Introduction to Hyperledger Sawtooth
    
## Introduction & Learning Objectives

### Learning Objectives

*   Understand the basics of Hyperledger Sawtooth v0.8.
*   Walk through a demonstrated scenario highlighting aspects of Hyperledger Sawtooth.
*   Discuss crucial components of Hyperledger Sawtooth, including the consensus algorithm_Proof of Elapsed Time,_ transaction families_,_ batches, and validators_._
*   Set up a running Hyperledger Sawtooth network and test an application.
*   Get involved in the framework discussion and development.

## Addressing Illegal, Unregulated, and Unreported Tuna Fishing (Demonstrated Scenario)

> According to the [World Economic Forum](https://www.weforum.org/agenda/2017/05/can-technology-help-tackle-illegal-fishing/), _"Illegal, unreported, and unregulated (IUU) fishing represents a theft of around 26 million tonnes, or close to $24 billion value of seafood a year."_

### Defining Our Actors

+ **Sarah** is the fisherman who sustainably and legally catches tuna.
+ **Tuna processing plant** processes and bags the tuna after they have been caught.
+ **Regulators** verify that the tuna has been legally and sustainably caught.
+ **Miriam** is a restaurant owner who will serve as the recipient in this situation.

![Actors](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/3deee7052b123b20c15de7aaf7c3d3fc/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/2_-__Sawtooth__Demonstrated_Scenario__1_.jpg)

We will be describing how tuna fishing can be improved starting from the source, fisherman Sarah, and the process by which her tuna ends up at Miriam's restaurant.

### Featured Hyperledger Sawtooth Elements

+ **Transaction validators** validate transactions.
+ **Transaction families** are smart contracts in Hyperledger Sawtooth. They define the operations that can be applied to transactions. Transaction families consist of both transaction processors (the server-side logic) and clients (for use from Web or mobile applications).
+ **Transaction processor** is the server-side business logic of transaction families that acts upon network assets.
+ **Transaction batches** are clusters of transactions that are either all committed to state or are all not committed to state.
+ **The network layer** is responsible for communicating between validators in a Hyperledger Sawtooth network, including performing initial connectivity, peer discovery, and message handling.
+ **Global state** contains the current state of the ledger and a chain of transaction invocations. The state for all transaction families is represented on each validator. The process of block validation on each validator ensures that the same transactions result in the same state transitions, and that the resulting data is the same for all participants in the network. The state is split into namespaces, which allow flexibility for transaction family authors to define, share, and reuse global state data between transaction processors.

### Why Sawtooth?

Miriam is a restaurant owner looking to source high quality tuna, that have been caught responsibly. Whenever Miriam buys tuna, she cannot be sure whether she can trust that the tuna she is purchasing is legally and sustainably caught, given the prominence of illegal and unreported tuna fishing. Luckily, Hyperledger Sawtooth can help!

Hyperledger Sawtooth is ideal for this scenario because of its ability to track an asset's (in this case tuna) provenance and journey. The ability to batch transactions together allows for all tuna within a catch to be entered as a whole. The distributed state agreement, novel consensus algorithm, and decoupled business logic from the consensus layer allow Miriam to be confident that she is buying tuna that has been legally caught.

### The Supply Chain

Hyperledger Sawtooth is extremely scalable and able to withstand high throughput of data, which makes it a great option for production supply chain scenarios.

We will start with Sarah, our licensed tuna fisher, who sells her tuna to multiple restaurants. Sarah operates as a private business, in which her company frequently makes international deals. Through an application, Sarah is able to gain entry to a Hyperledger Sawtooth blockchain network comprised of other fishermen, as well as processing plants, regulators, and restaurant owners. Sarah, as  well as the processing plants, have the ability to add and update information to this ledger as tuna passes through the supply chain, while regulators and restaurants have read access to ledger records.

### The Tuna Asset

With each catch, Sarah records some information about each individual tuna, including: a unique ID number, the location and time of the catch, its weight, and who caught the fish. For the sake of simplicity, we will stick with these data attributes. However, in an actual application, many more details would be recorded, from toxicology, to other physical characteristics, such as the temperature of the tuna.

These details are saved in the global state as a _**key/value pair**_ based on the specifications of a _**transaction** **family**_, while the _**transaction processor**_ allows Sarah's application to effectively create a transaction on the ledger. Please see the example below:

**$ var tuna = { id: ‘0002’, holder: ‘Sarah’, location: { latitude: '15.623036831528264', longitude: '-158.466796875'}, when: '20170635123546', weight: ‘58lbs’ }**

### Recording a Catch

After Sarah catches her tuna and records data for each tuna, she is able to treat a haul of tuna as a single _**batch**_ of transactions. As a reminder, _**transaction batches**_ are clusters of transactions that are committed to state together. Using batches, Sarah is able to record many tuna together, while still being able to specify data for each tuna. If one of the tuna transactions is invalid, the entire shipment is invalidated, that is, no tuna within the batch of tuna is validated.

### Reaching Consensus

After a batch of many transactions is submitted to the network, the network’s consensus algorithm is run to choose a node to publish the transaction block. By default, the _**Proof of Elapsed Time**_ consensus algorithm is used, and the _**transaction validator**_ with the shortest wait time publishes the transaction block. The transaction block is then broadcast to the publishing nodes.

Each node within the network receives the transaction block, and validators verify whether the transaction is valid or not. If the transaction is validated, the global state is updated.

Hyperledger Sawtooth is unique because of its distributed state agreement, whereby every node in the system has the same understanding of information, and, as the supply chain matures, the data stored remains consistent across the network.

With the global state adjusted, the processing plant, the regulator, and Miriam are able to see the details of the catch and who the current holder is, thus, keeping the supply chain transparent and verifiable.

### Other Actors in the Supply Chain

Before Sarah's tuna can reach Miriam's restaurant, they need to go through a tuna processing plant. Also, regulators will need to verify and view details from the ledger. Therefore, both parties will gain entry to this Sawtooth blockchain. The regulators will need to query the ledger to confirm that Sarah is legally catching her fish. At the same time, tuna processing plants will need to record their processing and shipping of the tuna on the ledger.

### Summary of Transaction Flow

Now, let's review the summary of the transaction flow:

![Summary of Transaction Flow](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/e0c503b430152897e29dec1c95ba99e2/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Sawtooth_section_3_summary_of_transaction_flow.png)

1.  Sarah catches a tuna and uses the application's user interface to record all the details about the catch to the ledger. An entire haul of tuna can be treated as a transaction batch, with each individual tuna registered as a transaction within the batch.
2.  After the details of the catch are saved to the ledger and the tuna is passed along the supply chain, the processing plant may use their own application to query the ledger for details about specific catches, such as weight. The processing plant will add details reflecting the processing date and time, as well as other relevant information.
3.  As the tuna is passed along the supply chain, the regulator may use their respective application to query the ledger for details about specific catches, such as the owner and location of the catch, to verify legitimacy.
4.  Lastly, when the haul of tuna arrives at Miriam's restaurant, Miriam is able to use her application to query the ledger, to check and make sure Sarah was truthful in her account of where each fish was sourced. This, in turn, guarantees Miriam's restaurant is serving their customers the sustainably caught fish they advertise.

## Key Components and Transaction Flow

### Requirements Supported by Hyperledger Sawtooth

Hyperledger Sawtooth is a blockchain framework with potential in IoT, manufacturing, finance, and enterprise. Hyperledger Sawtooth supports diverse requirements, including both permissioned and permissionless deployments, and a pluggable consensus algorithm. This framework also provides a revolutionary consensus algorithm, Proof of Elapsed Time (PoET), that allows for versatility and scalability suited for a variety of solutions.

Hyperledger Sawtooth supports many different infrastructural requirements, such as:

*   Permissioned and permissionless infrastructure
*   Modular blockchain architecture
*   Scalability, which is good for larger blockchain networks due to higher throughput
*   Many languages for transaction logic.

### Transaction Batching

Hyperledger Sawtooth **transaction batches** are clusters of transactions that are either all committed to state together, or none of the transactions are committed at all. As a result, transaction batches are often described as an atomic unit of change, since a group of transactions are treated as one, and are committed to the state as one. Every single transaction in Hyperledger Sawtooth is submitted within a batch. Batches can contain as little as a single transaction.

When a transaction is created by a client, the batch is submitted to the validator (which we will cover more in depth in the next section). Transactions are organized into a batch in the order they are intended to be committed. The validator then, in turn, applies each transaction within the batch, leading to a change in the global state. The batch is committed to the state. If one transaction within the batch is invalid, then none of the transactions within that batch are committed.

In summary, transaction batching allows a group of transactions to be applied in a specific order, and if any are invalid, then none of the transactions are applied. This is a powerful tool that can be utilized by many enterprise solutions, as it provides greater efficiency and control for end users.

### Validators

In any blockchain network, modifying the global state requires creating and applying a transaction. In Hyperledger Sawtooth, **validators** apply blocks that cause a change in the state. More specifically, validators validate transaction blocks, and ensure that transactions result in state changes that are consistent across all participants in the network.

To start, a user creates a transaction batch and submits it to a validator via a client and REST API. The validator then checks the transaction batch and applies it if it is considered valid, resulting in a change to the state. In terms of our demonstrated scenario, Sarah, the fisherman, creates a transaction batch to record information about a group of tuna catches. The validator would then apply the transactions, and the state would be updated if all appropriate attributes are present: a unique ID number, location and time of the catch, weight, and who caught the fish. If any of these elements are missing, the transactions within the batch would not be applied, and the state would not be updated.

![Sawtooth validators](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/c7b3d5552070184b7b56fc25d316f585/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Sawtooth_validators.png)

### Journal

In Hyperledger Sawtooth, the **journal** maintains and extends the blockchain for the validator. It is responsible for validating candidate blocks, evaluating valid blocks to determine if they are the correct chain head, and generating new blocks to extend the chain. Transaction batches arrive at the journal, where they are evaluated, validated, and added to the blockchain. Additionally, the journal resolves forks, which occur due to disagreements over who commits a block. Once blocks are completed, they are delivered to the _ChainController_ for validation and fork resolution.  To see how the elements of the journal interact with one another, take a look at the diagram on the next page.

Another key feature of the journal is its flexibility in allowing pluggable consensus algorithms.

### Consensus Interface

Consensus in Hyperledger Sawtooth is modular, meaning that the consensus algorithm can be easily modified. Hyperledger Sawtooth provides an abstract interface that supports both PBFT and Nakamoto-style algorithms. To implement a new consensus algorithm in Hyperledger Sawtooth, you must implement the distinct interface for: block publisher, block verifier, and fork resolution.

*   **Block publisher**: Creates new candidate blocks to extend the chain.
*   **Block verifier**: Verifies that candidate blocks are published in accordance with consensus rules.
*   **Fork resolver**: Chooses which fork to use as the chain head for consensus algorithms that result in a fork.

![Consensus interface](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/a6cfe922dbd88b452ce58d493273f9e4/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Consensus_interface.png)

### Transaction Families

As with any blockchain framework, transaction updates need to be approved and shared between many untrusted parties. As such, many blockchain frameworks have a mechanism for supporting distributed ledgers, as well as a method for changing the state of the shared ledger.

In Hyperledger Sawtooth, the data model that captures the state and the transaction language that changes the state are implemented using **transaction families**.

A transaction family consists of a group of operations or _transaction types_ that are allowed on the shared ledgers. This allows for flexibility in the level of versatility and risk that exists on a network. Transaction families are often called 'safer' smart contracts, because they specify a predefined set of acceptable smart contract templates, as opposed to programming smart contracts from scratch.

Hyperledger Sawtooth’s transaction families can be written in many languages, including Javascript, Java, C++, Python, and Go, which allows flexibility for businesses to bring their own transaction families. Hyperledger Sawtooth allows the developers to specify the address/namespace of data, which provides flexibility in defining, sharing, and reusing data between different transaction families.

![Transaction families](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/8f6a37e9af4a9e8117c7d1b779e0b405/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Transaction_families.png)

### Transaction Processors

A **transaction processor** provides the server-side business logic that operates on assets within a network. Hyperledger Sawtooth supports pluggable transaction processors, that are customizable based on the specific application. Businesses are able to develop transaction processors that do exactly what their applications need. Additionally, transaction processors can be written in a variety of languages (Java, Python, C, C++, JavaScript, and Go), allowing for ease of use and simplicity when handling assets.

Each node within the Hyperledger Sawtooth network runs a transaction processor. This transaction processor processes incoming transactions submitted by authorized clients. In Hyperledger Sawtooth, the Sawtooth SDK allows programmers to focus on developing application logic, as opposed to building communication mechanisms between transaction processors.

Later in this chapter, in the _Writing an Application_ section, you will be able to explore how exactly transaction processors interact with a client and other Hyperledger Sawtooth elements.

### Sawtooth Node

Hyperledger Sawtooth organizations run a node that interacts with the Hyperledger Sawtooth network. Each node runs at least three things:

*   The main **validator** process
*   The **REST service** listening for requests (could be transaction posts or state queries)
*   One or more **transaction processors**

Each organization that enters the Hyperledger Sawtooth network runs at least one node, and receives transactions submitted by fellow nodes.

![Sawtooth node](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/274566f591da0f1ee0ea5035f5415a7e/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Sawtooth_node.png)

### Introducing Proof of Elapsed Time (PoET)

The consensus algorithm commonly used in a Hyperledger Sawtooth network is the **Proof of Elapsed Time**, or **PoET**. PoET impartially determines who will commit a transaction to state using a lottery function that elects a leader from many different distributed nodes.

Hyperledger Sawtooth’s PoET algorithm differs from the Proof of Work algorithm implemented by the Bitcoin blockchain in that Proof of Work relies on vast amounts of power, while Proof of Elapsed Time is able to ensure trust and randomness in electing a leader, without the high power consumption. PoET allows for increased scalability and participation, as every node in the network has an equal opportunity to create the next block on the chain.

### How Proof of Elapsed Time Works

To start, each validator within the network requests a wait time from an enclave, or a trusted function. This is where the 'Elapsed Time' comes into play. The validator with the shortest wait time for a specific block is appointed the leader, and creates the block to be committed to the ledger. As a result, a truly random leader is elected, and the amount of power or type of hardware you have will not give you an advantage. Using simple functions, the network can verify that the winning validator did indeed 'win', by proving that it had the shortest time to wait before assuming the leadership position.

Proof of Elapsed Time is revolutionary in its ability to achieve distributed consensus using a lottery function. This not only allows for easy verification and fairness within the network, but also for incredible scalability. Without the heavy costs of participating in consensus, anyone can participate in the network. One of Hyperledger Sawtooth's main advantages is that it allows the size of the network to scale. That is, Hyperledger Sawtooth is nearly limitless in the network size it can support.

### Forks

While PoET provides many benefits and aids tremendously with scalability, there is a downside to the PoET consensus algorithm. And that is the issue of **forks**. The PoET algorithm may lead to forking, in which two 'winners' propose a block. Each fork has to be resolved by validators, and this results in a delay in reaching consistency across the network.

> As stated in the Sawtooth documentation: _"Completed Blocks are delivered to the Chain controller for validation and fork resolution." [https://intelledger.github.io/architecture/journal.html](https://intelledger.github.io/architecture/journal.html)_

## Installing Hyperledger Sawtooth

### Technical Prerequisites

In order to successfully install Hyperledger Sawtooth, you should be familiar with Go and Node.js programming languages, and have the following features installed on your computer: cURL, Node.js, npm package manager, Go language, Docker, and Docker Compose.

For further details on these prerequisites, visit Chapter 4, _Technical Requirements_.

### Installing Hyperledger Sawtooth

Hyperledger Sawtooth is a suite that permits the creation and utilization of a distributed ledger. Installing Hyperledger Sawtooth will involve adding signing keys for the software creator to our environment, including the repository that contains the code to our system, and performing a typical update/install.

Hyperledger Sawtooth validators can be run either from pre-built Docker containers, or natively, using Ubuntu 16.04. In this tutorial, we will demonstrate how to set up Hyperledger Sawtooth using Docker.

Our simple Sawtooth environment will include a single validator using the dev-mode consensus, a REST API connected to the validator, transaction processors, and a client container.

Download the following Docker Compose file as **sawtooth-default.yaml** at [https://raw.githubusercontent.com/hyperledger/education/master/LFS171x/sawtooth-material/sawtooth-default.yaml](https://raw.githubusercontent.com/hyperledger/education/master/LFS171x/sawtooth-material/sawtooth-default.yaml).

### Starting Hyperledger Sawtooth

+ We will start by opening a terminal window. You should change your working directory to the same directory where the **sawtooth-default.yaml** Docker Compose file is saved. Make sure you do **not** have anything else running on port 8080 or port 4004.
+ Run the following command: **$ docker-compose -f sawtooth-default.yaml up**
+ This command will download the Docker images that comprise the Hyperledger Sawtooth demo environment. The download will take several minutes. The terminal will start to display containers registering and creating initial blocks.
+ Make sure to have Docker running on your device before running the commands in this section. Otherwise, you will get a similar error to the one below: **ERROR: Couldn't connect to Docker daemon. You might need to start Docker for Mac.**

### Logging into the Client Container

+ The client container is used to run Sawtooth CLI commands, which is the usual way to interact with validators or validator networks at this time. Open a new terminal window and navigate to the same directory mentioned in this section.
+ Log into the client container by running the following command: **$ docker exec -it sawtooth-client-default bash**
+ In your terminal, you will see something similar to the following: **root@75b380886502:/#**
+ Your environment is now set up and you are ready to start experimenting with the network. But first, let’s confirm that our validator is up and running, and reachable from the client container. To do this, run the following command: **$ curl http://rest-api:8080/blocks**
+ After running this command, you should see a **json** object response with “data”, array of batches, header, etc.
+ And, to check the connectivity from the host computer, run the following command in a new terminal window (it does not need to be the same directory as mentioned previously in this section): **$ curl http://localhost:8080/blocks**
+ After running this command, you should see a **json** object response with “data”, array of batches, header, etc.

### Stopping Hyperledger Sawtooth

First, press **Ctrl+C** from the window where you originally ran **docker-compose**.
Then, in the terminal, you will see containers stopping. After that, run the following command: **$ docker-compose -f sawtooth-default.yaml down**

## Writing an Application

### Applications

In a blockchain application, the blockchain will store the state of the system, in addition to the immutable record of transactions that created that state. A client application will be used to send transactions to the blockchain. The smart contracts will encode some (if not all) of the business logic.

### Designing an Application Using the Javascript SDK

We will be looking at a sample blockchain application that interfaces with Hyperledger Sawtooth. This application was written by Zac Delventhal, a maintainer on Hyperledger Sawtooth, and was originally presented at Midwest JS 2017. This example is meant to introduce you to writing an application that interfaces with Hyperledger Sawtooth, as opposed to creating a complete production implementation.

Hyperledger Sawtooth offers an SDK to abstract away many of the complicated aspects of blockchain technology. SDKs are available in multiple languages, including Java, Python, and Javascript. In this example, we will be working with the Javascript SDK. We will be examining a web client and transaction processor putting our demonstrated scenario into action.

### Review of Hyperledger Sawtooth Components

**Transaction validators** validate transactions.

**Transaction families** consist of _"a group of operations or transaction types"_ ([Dan Middleton](https://www.hyperledger.org/blog/2017/06/22/whats-a-transaction-family)) that are allowed on the shared ledger. Transaction families consist of both transaction processors (the server-side logic) and clients (for use from Web or mobile applications).

The **transaction processor** provides the server-side business logic that operates on assets within a network.

**Transaction batches** are clusters of transactions that are either all committed to state, or are all not committed to state.

The **network layer** is responsible for communicating between validators in a Hyperledger Sawtooth network, including performing initial connectivity, peer discovery, and message handling.

The** global state** contains the current state of the ledger and a chain of transaction invocations. The state for all transaction families is represented on each validator. The state is split into namespaces, which allow flexibility for transaction family authors to define, share, and reuse global state data between transaction processors.

### Sawtooth Tuna Application

Let’s get our feet wet with an example of a simple Hyperledger Sawtooth blockchain application, written in JavaScript, that relates to the tuna fish supply scenario we discussed in our demonstrated scenario. The _Sawtooth Tuna Chain_ allows a user to create named assets (tuna fish), and transfer them between different holders designated by a public key.

In our example, we will look at:

*   A transaction processor
*   A simple browser-based client.

The transaction processor interfaces with a Sawtooth validator, and handles the validation of transactions.

The client is a simple browser-based user interface, and will allow a user to manage public/private key pairs, and submit transactions using the Sawtooth REST API.

Just in case you have not done so, clone the educational repository for this course with the _Sawtooth Tuna Chain_ application code we have provided. Navigate in your terminal window to your projects folder or desktop.

+ **$ git clone https://github.com/hyperledger/education.git**
+ **$ cd education**
+ **$ cd LFS171x**
+ **$ cd sawtooth-material**

### File Structure of Application

Here you can see the file structure of the Sawtooth application:

![The file structure of the Sawtooth application](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/d99202fc5d73b815887148f17dc52af4/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/File_Structure_of_Sawtooth_Application.png)

### Installation

Make sure you have Docker running on your machine before you run the next command. If you do not have Docker installed, you should review Chapter 4, _Technical Requirements_.

**Note**: Make sure you are in the **sawtooth-material** folder

We will use the provided **docker-compose** file to spin up some default Sawtooth components, including a validator and a REST API. Run the following command to start Sawtooth up: **$ docker-compose -f sawtooth-default.yaml up**

**Note**: If you are getting an error, you may need to run the following instead: **$ docker-compose -force sawtooth-default.yaml up**

Let’s run the following commands to install dependencies for the transaction processor:

+ **$ cd sawtooth-tuna**  
+ **$ cd processor**  
+ **$ npm install**

Then, we will navigate to the client folder, and run these commands to install dependencies for and build the client:

+ **$ cd ..**  
+ **$ cd client**  
+ **$ npm install**  
+ **$ npm run build**
+ **$ cd ..**  

**Note**: Make sure you are in the **sawtooth-tuna** folder.

### Transaction Processor

To review, there are two main components of a **transaction processor**: _a processor class_ and a _handler class_. The Javascript SDK offers a general-purpose processor class. The handler class is customized to the application, and holds the business logic for transactions. Usually, there is one transaction processor per use case.

Make sure you are in the **sawtooth-tuna** folder. In a new terminal window, start up the transaction processor by running the following:

+ **$ cd processor**  
+ **$ npm start**

### Browser Client

Start the client simply by opening **../client/index.html** in any browser window of your choice. One way of doing so is simply to open up the **education** folder and navigate to **sawtooth-tuna**. Click on the **client** folder and drag the **index.html** folder into a browser window.

### Creating a User

We are now ready to test out our application through the user interface. We have four options:

*   **Create a user** within the supply chain
*   **Create a record** of a tuna catch
*   **Transfer** a tuna
*   **Accept or reject** a transfer.

The application logic is contained mainly within the **handlers.js** file within the **processor** folder.
Users are just public/private key pairs stored in **localStorage**.

`makePrivateKey: () => {
let privateKey
do privateKey = randomBytes(32)
while (!secp256k1.privateKeyVerify(privateKey))
return privateKey.toString('hex')
}`

This function creates a random 256-bit private key represented as a 64-char hex string on the client side. This should not be shared with anyone else.

`getPublicKey: privateKey => {
const privateBuffer = _decodeHex(privateKey)
const publicKey = secp256k1.publicKeyCreate(privateBuffer)
return publicKey.toString('hex')
}`

This function returns the public key derived from the 256-bit private key created above. This is the key that is safe to share. It takes in the 256-bit private key and returns the public key as a hex string.

These two keys are stored together in the browser’s **localStorage**. If you do _Inspect Element_ and navigate to the _Application_ tab, under **localStorage**, you can view the key pairs.

**Note**: This method is not the way this would be done in a production application. **

Within the user interface, you can create these keys from the _Select Holder_ dropdown. You can use this same dropdown to switch between multiple users in **localStorage**.

![Select Holder dropdown](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/2080216b15e52eed8182a02036719b1c/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Tuna_Holder_drop_down.png)

![Create new keypair](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/5f06b8ccc63eaa2aceae22bae6dd2bc7/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Tuna_Create_New_Key_Pair.png)

### Creating a Record of Tuna

`const createAsset = (asset, owner, state) => {
            const address = getAssetAddress(asset)
            return state.get(\[address\])
            .then(entries => {
            const entry = entries\[address\]
            if (entry && entry.length > 0) {
                throw new InvalidTransaction('Asset name in use')
            }
            return state.set({
            \[address\]: encode({name: asset, owner})
        })
    })
}
const getAddress = (key, length = 64) => {
    return createHash('sha512').update(key).digest('hex').slice(0, length)
}
const getAssetAddress = name => PREFIX + '00' + getAddress(name, 62)`

The **createAsset** function adds a new asset to the state by taking in an asset name, owner as the public key, and state. Once an asset address for a specific tuna is created with the **sha512** hash, the state is set to **state.set({ \[address\]: encode({name: asset, owner: owner}) })**.

Within the user interface, select the owner of the tuna in the _Select Holder_ dropdown, then provide a unique name for the tuna in the _Create Tuna Record_ text box. Lastly, click the _Create_ button.

![Create tuna record](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/ecf5dc6278ce756c419daa608a5a12c8/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Tuna_Create.png)

After doing this, you will see the tuna show up in the _Tuna List_, along with its associated owner.

![Tuna List showing the tuna and its associated owner](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/542e69f298f8ece8eb21325c675e0fe0/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Tuna_List.png)

### Transferring a Tuna

`
const transferAsset = (asset, owner, signer, state) => {
	const address = getTransferAddress(asset)
	const assetAddress = getAssetAddress(asset)
	return state.get(\[assetAddress\])
	.then(entries => {
		const entry = entries\[assetAddress\]
		if (!entry || entry.length === 0) {
		throw new InvalidTransaction\]('Asset does not exist')
		}
		if (signer !== decode(entry).owner) {
		throw new InvalidTransaction('Only an Asset\\'s owner may transfer it')
		}
		return state.set({
		\[address\]: encode({name: asset, owner: owner})
		})
	})
}
`

The **transferAsset** function proposes a transfer of ownership for a particular asset to the state by taking in the asset name, owner to transfer to, signer (current owner) and state. If all the checks pass, the state is updated with the proposed transfer **\[address\]: encode({asset, owner})**.

Any tuna assigned to a particular user can be transferred to another owner (public key) using the dropdowns under _Transfer Tuna_. Note that the transfer must be accepted by that user before it is finalized.

![Tuna transfer steps](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/b94d1ad03f10fbe7924dcd9341641bf7/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Tuna_Transfer.png)

### Accepting or Rejecting Transfers (Part I)

`
const acceptTransfer = (asset, signer, state) => {
    const address = getTransferAddress(asset)
    return state.get(\[address\])
    .then(entries => {
        const entry = entries\[address\]
        if (!entry || entry.length === 0) {
        throw new InvalidTransaction('Asset is not being transfered')
        }
        if (signer !== decode(entry).owner) {
        throw new InvalidTransaction(
        'Transfers can only be accepted by the new owner'
        )
        }
        return state.set({
        \[address\]: Buffer(0),
        \[getAssetAddress(asset)\]: encode({name: asset, owner: signer})
        })
    })
}
`

The **acceptTransfer** function allows a user to accept a transfer of an asset and change the asset ownership.

`
const rejectTransfer = (asset, signer, state) => {
    const address = getTransferAddress(asset)
    return state.get(\[address\])
    .then(entries => {
        const entry = entries\[address\]
        if (!entry || entry.length === 0) {
        throw new InvalidTransaction('Asset is not being transfered')
        }
        if (signer !== decode(entry).owner) {
        throw new InvalidTransaction(
        'Transfers can only be rejected by the potential new owner')
        }
        return state.set({
        \[address\]: Buffer(0)
        })
    })
}
`

The **rejectTransfer** function allows a user to reject a transfer of an asset, and the asset owner will remain with the original user.

Within the user interface, any pending transfers for the selected user will appear under _Accept Tuna_. These can be accepted (with an immediate change in ownership), or rejected with the corresponding buttons.

### Accepting or Rejecting Transfers (Part III)

When we click _Transfer_, the proposal is sent to the Hyperledger Sawtooth network. If we switch the _Select Holder_ field to the owner identified by the key starting with **03**, we will see that we can now _Accept_ or _Reject_ this ownership change.

**NOTE**: If someone other than the owner tries to transfer ownership, you will see an error returned to the client from the Hyperledger Sawtooth network.

![Accepting or rejecting the tuna transfer](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/f1a4c52de931fb169b1685917c5d832b/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Tuna_Accept-Reject.png)

### Shutting Down Docker

**Note**: When we are done with this tutorial, run the following command to shut down Docker: **$ docker-compose -f sawtooth-default.yaml down**

### Application Flow

![A diagram of the Sawtooth Application Flow](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/148eb99c4e9410d799444b72fb7c6785/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/sawtooth-application-txflowdiagram.png)

Hyperledger Sawtooth allows entities to securely update and read the distributed ledger without involving a central authority. Developers create application and transaction processor business logic (smart contract).

Through the client application, users (fisherman, regulator, restaurant) are able to modify the state by creating and applying transactions.

Through a REST API, the client application creates a batch containing a single transaction, and submits it to the validator.

The validator applies the transaction using the transaction processor, which makes a change to the state (e.g., creating a record of a tuna catch).

## Joining the Hyperledger Sawtooth Community

### Becoming Involved with the Hyperledger Sawtooth Project

Hyperledger Sawtooth is an open source project, where ideas and code can be publicly discussed, created, and reviewed. There are many ways to join the Hyperledger Sawtooth community, and in the next few pages we are highlighting some of the ways to get involved, either from a technical standpoint, or from an ideas/issues creation perspective.

### Community Meetings and Mailing Lists

You can join the online meetings on Sawtooth Sprint planning and Tech Forums. Check the Hyperledger Community Meetings Calendar for the timing of these meetings: [https://calendar.google.com/calendar/embed?src=linuxfoundation.org_nf9u64g9k9rvd9f8vp4vur23b0%40group.calendar.google.com&ctz=America/SanFrancisco](https://calendar.google.com/calendar/embed?src=linuxfoundation.org_nf9u64g9k9rvd9f8vp4vur23b0%40group.calendar.google.com&ctz=America/SanFrancisco).

Some of the recordings of previous virtual tech forums on Hyperledger Sawtooth can be found here: [https://drive.google.com/drive/folders/0B_NJV6eJXAA1VnFUakRzaG1raXc](https://drive.google.com/drive/folders/0B_NJV6eJXAA1VnFUakRzaG1raXc).

You can also join the mailing list(s) for technical discussions and announcements: [https://lists.hyperledger.org/mailman/listinfo/hyperledger-stl](https://lists.hyperledger.org/mailman/listinfo/hyperledger-stl).

### GitHub and Rocket.Chat

You can also get involved with the Hyperledger Sawtooth community on GitHub and Rocket.Chat.

All code available on GitHub is forkable and viewable:

*   [https://github.com/hyperledger/sawtooth-core](https://github.com/hyperledger/sawtooth-core)
*   [https://github.com/hyperledger/sawtooth-supply-chain](https://github.com/hyperledger/sawtooth-supply-chain).

You can also join the live conversations on Rocket.Chat (which is an alternative to Slack), using your Linux Foundation ID:

*   [https://chat.hyperledger.org/channel/sawtooth](https://chat.hyperledger.org/channel/sawtooth)
*   [https://chat.hyperledger.org/channel/sawtooth-consensus](https://chat.hyperledger.org/channel/sawtooth-consensus)
*   [https://chat.hyperledger.org/channel/sawtooth-burrow](https://chat.hyperledger.org/channel/sawtooth-burrow).

### Learning Objectives (Review)

You should now be able to:
*   Understand the basics of Hyperledger Sawtooth v0.8.
*   Walk through a demonstrated scenario highlighting aspects of Hyperledger Sawtooth.
*   Discuss crucial components of Hyperledger Sawtooth, including the consensus algorithm_Proof of Elapsed Time,_ transaction families_,_ batches, and validators_._
*   Set up a running Hyperledger Sawtooth network and test an application.
*   Get involved in the framework discussion and development.
        
# Chapter 7. Introduction to Hyperledger Fabric
    
## Introduction & Learning Objectives

### Learning Objectives

*   Understand the basics of Hyperledger Fabric v1.0.
*   Walk through and analyze a demonstrated scenario on Hyperledger Fabric.
*   Discuss crucial components of the Hyperledger Fabric architecture, including clients, peers, ordering service and membership service provider.
*   Set up a sample network and simple application with a Javascript SDK.
*   Discuss Chaincode (Hyperledger Fabric smart contract) and review an example.
*   Get involved in the framework discussion and development.

## Addressing Illegal, Unregulated, and Unreported Tuna Fishing (Demonstrated Scenario)

### Defining Our Actors

**Sarah** is the fisherman who sustainably and legally catches tuna.
**Regulators** verify that the tuna has been legally and sustainably caught.
**Miriam** is a restaurant owner who will serve as the end user, in this situation.
**Carl** is another restaurant owner fisherman Sarah can sell tuna to.

![Fabric demonstrated scenario actors: Sarah, regulator, Carl, Miriam](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/8a7ca0b7964bdcbe856743f6f5519837/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Fabric_demonstrated_scenario_actors.png)

Using Hyperledger Fabric, we will be demonstrating how tuna fishing can be improved starting from the source, fisherman Sarah, and the process by which she sells her tuna to Miriam's restaurant.

### Featured Hyperledger Fabric Elements

+ **Channels** are data partitioning mechanisms that allow transaction visibility for stakeholders only. Each channel is an independent chain of transaction blocks containing only transactions for that particular channel.
+ The **chaincode** (Smart Contracts) encapsulates both the asset definitions and the business logic (or transactions) for modifying those assets. Transaction invocations result in changes to the ledger.
+ The **ledger** contains the current world state of the network and a chain of transaction invocations. A shared, permissioned ledger is an append-only system of records and serves as a single source of truth.
+ The **network** is the collection of data processing peers that form a blockchain network. The network is responsible for maintaining a consistently replicated ledger.
+ The **ordering service** is a collection of nodes that orders transactions into a block.
+ The **world state** reflects the current data about all the assets in the network. This data is stored in a database for efficient access. Current supported databases are LevelDB and CouchDB.
+ The **membership service provider** (MSP) manages identity and permissioned access for clients and peers.

### The Catch

We will start with Sarah, our licensed tuna fisher, who makes a living selling her tuna to multiple restaurants. Sarah operates as a private business, in which her company frequently makes international deals. Through a client application, Sarah is able to gain entry to a Hyperledger Fabric blockchain network comprised of other fishermen, as well as regulators and restaurant owners. Sarah has the ability to add to and update information in the blockchain network's  ledger as tuna pass through the supply chain, while regulators and restaurants have read access to the ledger.

After each catch, Sarah records information about each individual tuna, including: a unique ID number, the location and time of the catch, its weight, the vessel type, and who caught the fish. For the sake of simplicity, we will stick with these six data attributes. However, in an actual application, many more details would be recorded, from toxicology, to other physical characteristics.

These details are saved in the world state as a key/value pair based on the specifications of a chaincode contract, allowing Sarah’s application to effectively create a transaction on the ledger. You can see the example below:

`$ var tuna = { id: ‘0001’, holder: ‘Sarah’, location: { latitude: '41.40238', longitude: '2.170328'}, when: '20170630123546', weight: ‘58lbs’, vessel : ‘9548E’ }`

### The Incentives

Miriam is a restaurant owner looking to source low cost, yet high quality tuna that have been responsibly caught. Whenever Miriam buys tuna, she is always uncertain whether she can trust that the tuna she is purchasing is legally and sustainably caught, given the prominence of illegal and unreported tuna fishing.

At the same time, as a legitimate and experienced fisherman, Sarah strives to make a living selling her tuna at a reasonable price. She would also like autonomy over who she sells to and at what price.

Luckily for both Sarah and Miriam, Hyperledger Fabric can help!

### The Sale

Normally, Sarah sells her tuna to restaurateurs, such as Carl, for $80 per pound. However, Sarah agrees to give Miriam a special price of $50 per pound of tuna, rather than her usual rate. In a traditional public blockchain, once Sarah and Miriam have completed their transaction, the entire network is able to view the details of this agreement, especially the fact that Sarah gave Miriam a special price. As you can imagine, having other restaurateurs, such as Carl, aware of this deal is not economically advantageous for Sarah.

![Fabric tina sale scenario](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/c30530b13fd201e9d92b50dcc04b48af/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/fabric_sale_scenario.png)

To remedy this, Sarah wants the specifics of her deal to not be available to everyone on the network, but still have every actor in the network be able to view the details of the fish she is selling. Using Hyperledger Fabric's feature of **channels**, Sarah can privately agree on the terms with Miriam, such that only the two of them can see them, without anyone else knowing the specifics.

Additionally, other fishermen, who are not part of Sarah and Miriam’s transaction, will not see this transaction on their ledger. This ensures that another fisherman cannot undercut the bid by having information about the prices that Sarah is charging different restaurateurs.

### The Regulators

Regulators will also gain entry to this Hyperledger Fabric blockchain network to confirm, verify, and view details from the ledger. Their application will allow these actors to query the ledger and see the details of each of Sarah’s catches to confirm that she is legally catching her fish. Regulators only need to have query access, and do not need to add entries to the ledger. With that being said, they may be able to adjust who can gain entry to the network and/or be able to remove fishermen from the network, if found to be partaking in illegal activities.

### Gaining Network Membership

Hyperledger Fabric is a permissioned network, meaning that only participants who have been approved can gain entry to the network. To handle network membership and identity, **membership service providers** (MSP) manage user IDs, and authenticate all the participants in the network. A Hyperledger Fabric blockchain network can be governed by one or more MSPs. This provides modularity of membership operations, and interoperability across different membership standards and architectures.

In our scenario, the regulator, the approved fishermen, and the approved restaurateurs should be the only ones allowed to join the network. To achieve this, a membership service provider (MSP) is defined to accommodate membership for all members of this supply chain. In configuring this MSP, certificates and membership identities are created. Policies are then defined to dictate the read/write policies of a channel, or the endorsement policies of a chaincode.

Our scenario has two separate chaincodes, which are run on three separate channels. The two chaincodes are: one for the price agreement between the fisherman and the restaurateur, and one for the transfer of tuna. The three channels are: one for the price agreement between Sarah and Miriam; one for the price agreement between Sarah and Carl; and one for the transfer of tuna. Each member of this network knows about each other and their identity. The channels provide privacy and confidentiality of transactions.

In Hyperledger Fabric, MSPs also allow for dynamic membership to add or remove members to maintain integrity and operation of the supply chain. For example, if Sarah was found to be catching her fish illegally, she can have her membership revoked, without compromising the rest of the network. This feature is critical, especially for enterprise applications, where business relationships change over time.

### Summary of Demonstrated Scenario

Below is a summary of the tuna catch scenario presented in this section:

1.  Sarah catches a tuna and uses the supply chain application’s user interface to record all the details about the catch to the ledger. Before it reaches the ledger, the transaction is passed to the endorsing peers on the network, where it is then endorsed. The endorsed transaction is sent to the ordering service, to be ordered into a block. This block is then sent to the committing peers in the network, where it is committed after being validated.
2.  As the tuna is passed along the supply chain, regulators may use their own application to query the ledger for details about specific catches (excluding price, since they do not have access to the price-related chaincode).
3.  Sarah may enter into an agreement with a restaurateur Carl, and agree on a price of $80 per pound. They use the blue channel for the chaincode contract stipulating $80/lb. The blue channel's ledger is updated with a block containing this transaction.
4.  In a separate business agreement, Sarah and Miriam agree on a special price of $50 per pound. They use the red channel's chaincode contract stipulating $50/lb. The red channel's ledger is updated with a block containing this transaction.

![Demonstrated scenario](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/61bbd7eb188c20cc6428391379df45e0/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Demonstrated_Tuna_Fishing_Scenario.png)

## Key Components and Transaction Flow

### Roles within a Hyperledger Fabric Network

There are three different types of roles within a Hyperledger Fabric network:

*   **Clients**  
    Clients are applications that act on behalf of a person to propose transactions on the network.
*   **Peers**  
    Peers maintain the state of the network and a copy of the ledger. There are two different types of peers: **endorsing** and **committing** peers. However, there is an overlap between endorsing and committing peers, in that endorsing peers are a special kind of committing peers. All peers commit blocks to the distributed ledger.  
	+ Endorsers : simulate and endorse transactions  
	+ Committers : verify endorsements and validate transaction results, prior to committing transactions to the blockchain.
*   **Ordering Service**  The ordering service accepts endorsed transactions, orders them into a block, and delivers the blocks to the committing peers.
    
### How to Reach Consensus

In a distributed ledger system, **consensus** is the process of reaching agreement on the next set of transactions to be added to the ledger. In Hyperledger Fabric, consensus is made up of three distinct steps:

*   Transaction endorsement
*   Ordering
*   Validation and commitment.

These three steps ensure the policies of a network are upheld. We will explore how these steps are implemented by exploring the transaction flow.

### Transaction Flow

Within a Hyperledger Fabric network, transactions start out with client applications sending transaction proposals, or, in other words, proposing a transaction to endorsing peers.

![This is the first step of the transaction flow, the transaction proposal.](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/21431955acd5b7888ca8d393c94deaf8/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Key_Components_-_Transaction_Proposal.png)

**Client applications** are commonly referred to as **applications** or **clients**, and allow people to communicate with the blockchain network. Application developers can leverage the Hyperledger Fabric network through the application SDK.

Each endorsing peer simulates the proposed transaction, without updating the ledger. The endorsing peers will capture the set of **R**ead and **W**ritten data, called **RW Sets**. These RW sets capture what was read from the current world state while simulating the transaction, as well as what would have been written to the world state had the transaction been executed. These RW sets are then signed by the endorsing peer, and returned to the client application to be used in future steps of the transaction flow.

![This is the second step of the transaction flow, when endorsers simulate transactions, generate RW sets, and return the signed RW sets back to the client application](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/13e5a6a80c0e150f46d45ec0634b86b8/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Transaction_flow_step_2.png)

Endorsing peers must hold smart contracts in order to simulate the transaction proposals.

#### Transaction Endorsement

A transaction endorsement is a signed response to the results of the simulated transaction. The method of transaction endorsements depends on the endorsement policy which is specified when the chaincode is deployed. An example of an endorsement policy would be "the majority of the endorsing peers must endorse the transaction". Since an endorsement policy is specified for a specific chaincode, different channels can have different endorsement policies.

The application then submits the endorsed transaction and the RW sets to the ordering service. Ordering happens across the network, in parallel with endorsed transactions and RW sets submitted by other applications.

![This is the third step in the transaction flow, the the client application submits to the ordering service](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/b6e7b13624d1cff4152e2c223538c355/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Transaction_flow_step_3.png)

The ordering service takes the endorsed transactions and RW sets, orders this information into a block, and delivers the block to all committing peers.

![This is step 4 of the transaction flow, where the orderer sends ordered transactions in a block to all committing peers](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/eeb54ce57f8a6018443e22f34b3ebad9/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Transaction_Flow_Step_4.png)

The **ordering service**, which is made up of a cluster of orderers, does not process transactions, smart contracts, or maintains the shared ledger. The ordering service accepts the endorsed transactions and specifies the order in which those transactions will be committed to the ledger. The Fabric v1.0 architecture has been designed such that the specific implementation of 'ordering' (Solo, Kafka, BFT) becomes a pluggable component. The default ordering service for Hyperledger Fabric is Kafka. Therefore, the ordering service is a modular component of Hyperledger Fabric.

#### Ordering

_Transactions within a timeframe are sorted into a block and are committed in sequential order._

In a blockchain network, transactions have to be written to the shared ledger in a consistent order. The order of transactions has to be established to ensure that the updates to the world state are valid when they are committed to the network. Unlike the Bitcoin blockchain, where ordering occurs through the solving of a cryptographic puzzle, or _mining_, Hyperledger Fabric allows the organizations running the network to choose the ordering mechanism that best suits that network. This modularity and flexibility makes Hyperledger Fabric incredibly advantageous for enterprise applications.

Hyperledger Fabric provides three ordering mechanisms: SOLO, Kafka, and Simplified Byzantine Fault Tolerance (SBFT), the latter of which has not yet been implemented in Fabric v1.0.

*   **SOLO** is the Hyperledger Fabric ordering mechanism most typically used by developers experimenting with Hyperledger Fabric networks. SOLO involves a single ordering node.
*   **Kafka** is the Hyperledger Fabric ordering mechanism that is recommended for production use. This ordering mechanism utilizes Apache Kafka, an open source stream processing platform that provides a unified, high-throughput, low-latency platform for handling real-time data feeds. In this case, the data consists of endorsed transactions and RW sets. The Kafka mechanism provides a crash fault-tolerant solution to ordering.
*   **SBFT** stands for Simplified Byzantine Fault Tolerance. This ordering mechanism is both crash fault-tolerant and byzantine fault-tolerant, meaning that it can reach agreement even in the presence of malicious or faulty nodes. The Hyperledger Fabric community has not yet implemented this mechanism, but it is on their roadmap.

These three ordering mechanisms provide alternate methodologies for agreeing on the order of transactions.

### Transaction Flow 

The committing peer validates the transaction by checking to make sure that the RW sets still match the current world state. Specifically, that the Read data that existed when the endorsers simulated the transaction is identical to the current world state. When the committing peer validates the transaction, the transaction is written to the ledger, and the world state is updated with the Write data from the RW Set.

![This is the fifth step of the transaction flow, where committing peers validate each transaction in the block](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/b05e5430900cf5e414e307d2f99de088/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Transaction_Flow_Step_5.png)

If the transaction fails, that is, if the committing peer finds that the RW set does not match the current world state, the transaction ordered into a block will still be included in that block, but it will be marked as invalid, and the world state will not be updated.

Committing peers are responsible for adding blocks of transactions to the shared ledger and updating the world state. They may hold smart contracts, but it is not a requirement.

Lastly, the committing peers asynchronously notify the client application of the success or failure of the transaction. Applications will be notified by each committing peer.

![This is the sixth step of the transaction flow, where committing peers asynchronously notify the application of the results of the transaction](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/ba380b73a55eff97c85da3abdc1d86e8/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Transaction_Flow_Step_6.png)

### Identity Verification

In addition to the multitude of endorsement, validity, and versioning checks that take place, there are also ongoing identity verifications happening during each step of the transaction flow. Access control lists are implemented on the hierarchical layers of the network (from the ordering service down to channels), and payloads are repeatedly signed, verified, and authenticated as a transaction proposal passes through the different architectural components.

### Transaction Flow Summary

It is important to note that the state of the network is maintained by peers, and not by the ordering service or the client. Normally, you will design your system such that different machines in the network play different roles. That is, machines that are part of the ordering service should not be set up to also endorse or commit transactions, and vice versa. However, there is an overlap between endorsing and committing peers on the system. Endorsing peers must have access to and hold smart contracts, in addition to fulfilling the role of a committing peer. Endorsing peers do commit blocks, but committing peers do not endorse transactions.

Endorsing peers verify the client signature, and execute a chaincode function to simulate the transaction. The output is the chaincode results, a set of key/value versions that were read in the chaincode (Read set), and the set of keys/values that were written by the chaincode. The proposal response gets sent back to the client, along with an endorsement signature. These proposal responses are sent to the orderer to be ordered. The orderer then orders the transactions into a block, which it forwards to the endorsing and committing peers. The RW sets are used to verify that the transactions are still valid before the content of the ledger and world state is updated. Finally, the peers asynchronously notify the client application of the success or failure of the transaction.

### Channels

Channels allow organizations to utilize the same network, while maintaining separation between multiple blockchains. Only the members of the channel on which the transaction was performed can see the specifics of the transaction. In other words, channels partition the network in order to allow transaction visibility for stakeholders only. This mechanism works by delegating transactions to different ledgers. Only the members of the channel are involved in consensus, while other members of the network do not see the transactions on the channel.

![There are three distinct channels - blue, orange, and grey, and each channel has its own application, ledger and peers](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/b23a6aaaa627620a0ab161c556ff87b3/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Key_Components_Channels.png)

The diagram above shows three distinct channels -- blue, orange, and grey. Each channel has its own application, ledger, and peers.

Peers can belong to multiple networks or channels. Peers that do participate in multiple channels simulate and commit transactions to different ledgers. The ordering service is the same across any network or channel.

A few things to remember:

*   The network setup allows for the creation of channels.
*   The same chaincode logic can be applied to multiple channels.
*   A given user can participate in multiple channels.

### State Database

The current state data represents the latest values for all assets in the ledger. Since the current state represents all the committed transactions on the channel, it is sometimes referred to as world state.

Chaincode invocations execute transactions against the current state data. To make these chaincode interactions extremely efficient, the latest key/value pairs for each asset are stored in a state database. The state database is simply an indexed view into the chain’s committed transactions. It can therefore be regenerated from the chain at any time. The state database will automatically get recovered (or generated, if needed) upon peer startup, before new transactions are accepted. The default state database, **LevelDB**, can be replaced with **CouchDB**.

*   LevelDB is the default key/value state database for Hyperledger Fabric, and simply stores key/value pairs.
*   CouchDB is an alternative to LevelDB. Unlike LevelDB, CouchDB stores JSON objects. CouchDB is unique in that it supports keyed, composite, key range, and full data-rich queries.

Hyperledger Fabric’s LevelDB and CouchDB are very similar in their structure and function. Both LevelDB and CouchDB support core chaincode operations, such as getting and setting key assets, and querying based on these keys. With both, keys can be queried by range, and composite keys can be modeled to enable equivalence queries against multiple parameters. But, as a JSON document store, CouchDB additionally enables rich query against the chaincode data, when chaincode values (e.g. assets) are modeled as JSON data.

![State Database](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/9fa87a2726077cff05169f85584224ac/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/State_Database.png)

### Smart Contracts

As a reminder, smart contracts are computer programs that contain logic to execute transactions and modify the state of the assets stored within the ledger. Hyperledger Fabric smart contracts are called **chaincode** and are written in Go. The chaincode serves as the business logic for a Hyperledger Fabric network, in that the chaincode directs how you manipulate assets within the network. We will discuss more about chaincode in the _Understanding Chaincode_ section.

### Membership Service Provider (MSP)

The membership service provider, or MSP, is a component that defines the rules in which identities are validated, authenticated, and allowed access to a network. The MSP manages user IDs and authenticates clients who want to join the network. This includes providing credentials for these clients to propose transactions. The MSP makes use of a _Certificate Authority_, which is a pluggable interface that verifies and revokes user certificates upon confirmed identity. The default interface used for the MSP is the **Fabric-CA API**, however, organizations can implement an External Certificate Authority of their choice. This is another feature of Hyperledger Fabric that is modular. Hyperledger Fabric supports many credential architectures, which allows for many types of External Certificate Authority interfaces to be used. As a result, a single Hyperledger Fabric network can be controlled by multiple MSPs, where each organization brings their favorite.

### What Does the MSP Do?

To start, users are authenticated using a certificate authority. The certificate authority identifies the application, peer, endorser, and orderer identities, and verifies these credentials. A signature is generated through the use of a _Signing Algorithm_ and a _Signature Verification Algorithm_.

Specifically, generating a signature starts with a _Signing Algorithm_, which utilizes the credentials of the entities associated with their respective identities, and outputs an endorsement. A signature is generated, which is a byte array that is bound to a specific identity. Next, the _Signature Verification Algorithm_ takes the identity, endorsement, and signature as inputs, and outputs 'accept' if the signature byte array corresponds with a valid signature for the inputted endorsement, or outputs 'reject' if not. If the output is 'accept', the user can see the transactions in the network and perform transactions with other actors in the network. If the output is 'reject', the user has not been properly authenticated, and is not able to submit transactions to the network, or view any previous transactions.

![The role of the membership service provider](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/2fe3f7dc2fa52699a96ef7948432113b/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/The_role_of_membership_service_provider.jpg)

### Fabric-Certificate Authority

In general, _Certificate Authorities_ manage enrollment certificates for a permissioned blockchain. **Fabric-CA** is the default certificate authority for Hyperledger Fabric, and handles the registration of user identities. The Fabric-CA certificate authority is in charge of issuing and revoking Enrollment Certificates (E-Certs). The current implementation of Fabric-CA only issues E-Certs, which supply long term identity certificates. E-Certs, which are issued by the Enrollment Certificate Authority (E-CA), assign peers their identity and give them permission to join the network and submit transactions.

## Installing Hyperledger Fabric

### Technical Prerequisites

In order to successfully install Hyperledger Fabric, you should be familiar with Go and Node.js programming languages, and have the following features installed on your computer: cURL, Node.js, npm package manager, Go language, Docker, and Docker Compose.

If you need further details on these prerequisites, visit Chapter 4, _Technical Requirements_.

### Installing Hyperledger Fabric Docker Images and Binaries

Next, we will download the latest released Docker images for Hyperledger Fabric, and tag them with the **latest** tag. Execute the command from within the directory into which you will extract the platform-specific binaries:

**$ curl -sSL [https://goo.gl/Q3YRTi](https://goo.gl/Q3YRTi) | bash**

**Note:** Check [https://hyperledger-fabric.readthedocs.io/en/latest/samples.html#binaries](https://hyperledger-fabric.readthedocs.io/en/latest/samples.html#binaries) for the latest URL (the blue portion in the above **curl** command) to pull in binaries.

This command downloads binaries for **cryptogen**, **configtxgen**, **configxlator**, **peer** AND downloads the Hyperledger Fabric Docker images. These assets are placed in a **bin** subdirectory of the current working directory.

To confirm and see the list of Docker images you’ve just downloaded, run: **$ docker images**

The expected response is:

![downloaded Docker images](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/ca726400444f52edbc3e54278077f8dd/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Fabric_installation_1.jpg)

**Note** the tags for each of the repositories above boxed in red. If the Docker images are not already tagged with the **latest** tag, perform the following command for each of the Docker images:

**$ docker tag hyperledger/fabric-tools:x86_64-1.0.2 hyperledger/fabric-tools:latest**

Swap out the blue portion with the tags you see in your list of repositories. Also, swap out the red portion with the name of the Docker image you are switching the tag for (e.g.: **fabric-tools**, **fabric-ccenv**, **fabric-orderer**, etc.). Repeat this step for all Docker images you see in the list.

In the screenshot above, the Docker images are already tagged. If this is the case for you, you do not need to do this extra step.

### Installing Hyperledger Fabric

As an additional measure, you may want to add the **bin** subdirectory to your **PATH** environment variable, so these can be picked up without needing to qualify the **PATH** to each binary. You can do this by running the following: **$ export PATH=$PWD/bin:$PATH**

To install the Hyperledger Fabric sample code which will be used in the tutorials, do:

+ **$ git clone [https://github.com/hyperledger/fabric-samples.git](https://github.com/hyperledger/fabric-samples.git)**
+ **$ cd fabric-samples/first-network**

### Starting a Test Hyperledger Fabric Network

Now that we have successfully installed Hyperledger Fabric, we can walk through setting up a simple network that has two members. To refer back to our demonstrated scenario, the network includes asset management of each tuna verified, transferred, and purchased between Sarah, the fisherman, and Miriam, the restaurateur. We’ll create a simple two member network consisting of two organizations (effectively, Sarah and Miriam), each maintaining two peers and an ordering service.

We will use Docker images to bootstrap our first Hyperledger Fabric network. It will also launch a container to run a scripted execution that will join peers to a channel, deploy, and instantiate the chaincode, and execute transactions against the chaincode.

### Getting Started with Your First Network

Are you ready to get started? Run this command ( within the **first-network** folder ): **$ ./byfn.sh -m generate**
A brief description will appear, along with a **Y/N** command line prompt. Respond with a **Y <Enter>** to continue.

This step generates all of the certificates and keys for all our various network entities, including the genesis block used to bootstrap the ordering service and a collection of configuration transactions required to create a channel.

Next, you can start the network with the following command: **$ ./byfn.sh -m up**
Another command line will appear, reply with **Y <Enter>** to continue.

Logs will appear in the command line, showing containers being launched, channels being created and joined, chaincode being installed, instantiated, and invoked on all the peers, as well as various transaction logs.

**Troubleshooting Note:**  
If you have difficulties with the two previous commands and you suspect that your Docker images may be at fault, you can start back from scratch, which will delete and untag the Docker images: **$ docker rmi -f $(docker images -q)**

Once you run this command, return to the _Installing Hyperledger Fabric Docker Images and Binaries_ page, at the beginning of this section.

### Finishing Up and Shutting Down the Network

Finally, let’s test bringing down this network.
Within the same terminal, do **Control+C** to exit the current execution.
Then, run the following command: **$ ./byfn.sh -m down**
Another command line will appear, reply with **Y <Enter>** to continue.

This command will kill your containers, remove the crypto material and four artifacts, and delete the chaincode images from your Docker Registry.

And that’s it for a simple demonstration!
These simple steps show how we can easily spin up and bring down a Hyperledger Fabric network, given the code we have. In the next section, we will learn more about chaincode.

## Understanding Chaincode

### Chaincode

In Hyperledger Fabric, **chaincode** is the 'smart contract' that runs on the peers and creates transactions. More broadly, it enables users to create transactions in the Hyperledger Fabric network's shared ledger and update the world state of the assets.

Chaincode is programmable code, written in Go, and instantiated on a channel. Developers use chaincode to develop business contracts, asset definitions, and collectively-managed decentralized applications. The chaincode manages the ledger state through transactions invoked by applications. Assets are created and updated by a specific chaincode, and cannot be accessed by another chaincode.

Applications interact with the blockchain ledger through the chaincode. Therefore, the chaincode needs to be installed on every peer that will endorse a transaction and instantiated on the channel.

There are two ways to develop smart contracts with Hyperledger Fabric:

*   Code individual contracts into standalone instances of chaincode
*   (More efficient way) Use chaincode to create decentralized applications that manage the lifecycle of one or multiple types of business contracts, and let the end users instantiate instances of contracts within these applications.

### Chaincode Key APIs

An important interface that you can use when writing your chaincode is defined by Hyperledger Fabric - [_ChaincodeStub_](https://godoc.org/github.com/hyperledger/fabric/core/chaincode/shim#Chaincode) and _[ChaincodeStubInterface](https://godoc.org/github.com/hyperledger/fabric/core/chaincode/shim#ChaincodeStub)_. The _ChaincodeStub_ provides functions that allow you to interact with the underlying ledger to query, update, and delete assets. The key APIs for chaincode include:

*   **func (stub *[ChaincodeStub](https://godoc.org/github.com/hyperledger/fabric/core/chaincode/shim#ChaincodeStub)) GetState(key [string](https://godoc.org/builtin#string)) (\[\][byte](https://godoc.org/builtin#byte), [error](https://godoc.org/builtin#error))**  
    Returns the value of the specified _key_ from the ledger. Note that **GetState** doesn't read data from the Write set, which has not been committed to the ledger. In other words, **GetState** doesn't consider data modified by **PutState** that has not been committed. If the key does not exist in the state database, **(nil, nil)** is returned.
*   **func (stub *[ChaincodeStub](https://godoc.org/github.com/hyperledger/fabric/core/chaincode/shim#ChaincodeStub)) PutState(key [string](https://godoc.org/builtin#string), value \[\][byte](https://godoc.org/builtin#byte)) [error](https://godoc.org/builtin#error)**  
    Puts the specified _key_ and _value_ into the transaction's Write set as a data-write proposal. **PutState** doesn't affect the ledger until the transaction is validated and successfully committed.
*   **func (stub *[ChaincodeStub](https://godoc.org/github.com/hyperledger/fabric/core/chaincode/shim#ChaincodeStub)) DelState(key [string](https://godoc.org/builtin#string)) [error](https://godoc.org/builtin#error)**  
    Records the specified _key_ to be deleted in the Write set of the transaction proposal. The _key_ and its _value_ will be deleted from the ledger when the transaction is validated and successfully committed.
    
### Overview of a Chaincode Program

When creating a chaincode, there are two methods that you will need to implement:

*   **Init**  
    Called when a chaincode receives an _**instantiate**_ or _**upgrade**_ transaction. This is where you will initialize any application state.
*   **Invoke**  
    Called when the _**invoke**_ transaction is received to process any transaction proposals.

As a developer, you must create both an **Init** and an **Invoke** method within your chaincode. The chaincode must be installed using the **peer chaincode install** command, and instantiated using the **peer chaincode instantiate** command before the chaincode can be invoked. Then, transactions can be created using the **peer chaincode invoke** or **peer chaincode query** commands.

### Sample Chaincode Decomposed - Dependencies

Let’s now walk through a sample chaincode written in Go, piece by piece:

`
package main
import (
"fmt"
"github.com/hyperledger/fabric/core/chaincode/shim"
"github.com/hyperledger/fabric/protos/peer"
)
`

The **import** statement lists a few dependencies that you will need for your chaincode to build successfully.

*   **fmt** \- contains **Println** for debugging/logging
*   **github.com/hyperledger/fabric/core/chaincode/shim** \- contains the definition for the chaincode interface and the chaincode stub, which you will need to interact with the ledger, as we described in the _Chaincode Key APIs_ section
*   **github.com/hyperledger/fabric/protos/peer** \- contains the peer protobuf package.

### Sample Chaincode Decomposed - Struct

`
type SampleChaincode struct {
}
`

This might not look like much, but this is the statement that begins the definition of an object/class in Go. **SampleChaincode** implements a simple chaincode to manage an asset.

### Sample Chaincode Decomposed - Init Method

Next, we’ll implement the **Init** method. **Init** is called during the chaincode instantiation to initialize data required by the application. In our sample, we will create the initial key/value pair for an asset, as specified on the command line:

`
func (t *SampleChaincode) Init(stub shim.ChainCodeStubInterface) peer.Response {
	// Get the args from the transaction proposal
	   args := stub.GetStringArgs()
	if len(args) != 2 {
		return shim.Error("Incorrect arguments. Expecting a key and a value")
	}
	// We store the key and the value on the ledger
	err := stub.PutState(args\[0\], \[\]byte(args\[1\]))
	if err != nil {
		return shim.Error(fmt.Sprintf("Failed to create asset: %s", args\[0\]))
	}
	return shim.Success(nil)
}
`


The **Init** implementation accepts two parameters as inputs, and proposes to write a key/value pair to the ledger by using the **stub.PutState** function. **GetStringArgs** retrieves and checks the validity of arguments which we expect to be a key/value pair. Therefore, we check to ensure that there are two arguments specified. If not, we return an error from the **Init** method, to indicate that something went wrong. Once we have verified the correct number of arguments, we can store the initial state in the ledger. In order to accomplish this, we call the **stub.PutState** function, specifying the first argument as the key, and the second argument as the value for that key. If no errors are returned, we will return success from the **Init** method.

### Sample Chaincode Decomposed - Invoke Method

Now, we’ll explore the **Invoke** method, which gets called when a transaction is proposed by a client application. In our sample, we will either get the value for a given asset, or propose to update the value for a specific asset.

`
func (t *SampleChaincode) Invoke(stub shim.ChaincodeStubInterface) peer.Response {
	// Extract the function and args from the transaction proposal
	fn, args := stub.GetFunctionAndParameters()
	var result string
	var err error
	if fn == "set" {
		result, err = set(stub, args)
	} else { // assume 'get' even if fn is nil
		result, err = get(stub, args)
	}
	if err != nil { //Failed to get function and/or arguments from transaction proposal
		return shim.Error(err.Error())
	}
	// Return the result as success payload
	return shim.Success(\[\]byte(result))
}
`

There are two basic actions a client can invoke: _get_ and _set_.

*   The _get_ method will be used to query and return the value of an existing asset.
*   The _set_ method will be used to create a new asset or update the value of an existing asset.

To start, we’ll call **GetFunctionandParameters** to isolate the function name and parameter variables. Each transaction is either a _set_ or a _get_. Let's first look at how the _set_ method is implemented:

`
func set(stub shim.ChaincodeStubInterface, args \[\]string) (string, error) {
	if len(args) != 2 {
		return "", fmt.Errorf("Incorrect arguments. Expecting a key and a value")
	}
	err := stub.PutState(args\[0\], \[\]byte(args\[1\]))
	if err != nil {
		return "", fmt.Errorf("Failed to set asset: %s", args\[0\])
	}
	return args\[1\], nil
}
`

The _set_ method will create or modify an asset identified by a key with the specified value. The _set_ method will modify the world state to include the key/value pair specified. If the key exists, it will override the value with the new one, using the **PutState** method; otherwise, a new asset will be created with the specified value.

Next, let's look at how the _get_ method is implemented:

`
func get(stub shim.ChaincodeStubInterface, args \[\]string) (string, error) {
	if len(args) != 1 {
		return "", fmt.Errorf("Incorrect arguments. Expecting a key")
	}
	value, err := stub.GetState(args\[0\])
	if err != nil {
		return "", fmt.Errorf("Failed to get asset: %s with error: %s", args\[0\], err)
	}
	if value == nil {
		return "", fmt.Errorf("Asset not found: %s", args\[0\])
	}
	return string(value), nil
}
`

The _get_ method will attempt to retrieve the value for the specified key. If the application does not pass in a single key, an error will be returned; otherwise, the **GetState** method will be used to query the world state for the specified key. If the key has not yet been added to the ledger (and world state), then an error will be returned; otherwise, the value that was set for the specified key is returned from the method.

### Sample Chaincode Decomposed - Main Function

The last piece of code in this sample is the **main** function, which will call the **Start** function. The **main** function starts the chaincode in the container during instantiation.

`
func main() {
	err := shim.Start(new(SampleChaincode))
	if err != nil {
		fmt.Println("Could not start SampleChaincode")
	} else {
		fmt.Println("SampleChaincode successfully started")
	}
}
`

## Chaincode Walkthrough (Demonstrated Scenario)

### Setting the Stage

Now that we have a general idea of how chaincode is coded, we will walk through a simple chaincode that creates assets on a ledger, based on our demonstrated scenario of creating records for tuna fish.

Sometimes, code snippets can get lost in translation, especially if the context doesn’t make much sense. In hopes of avoiding this, we have adjusted our example chaincode to address our demonstration scenario. The chaincode we will be examining in this section will record a tuna catch by storing it to the ledger, as well as allow for queries and updates to tuna catch records.

### Defining the Asset Attributes
-----------------------------

Bookmark this page

Here are the four example attributes of tuna fish that we will be recording on the ledger:

*   Vessel (string)
*   Location (string)
*   Date and Time (datetime)
*   Holder (string)

We create a Tuna Structure that has four properties. Structure tags are used by the **encoding/json** library.

`
type Tuna struct {
	Vessel string ‘json:"vessel"’
	Datetime string ‘json:"datetime"’
	Location string ‘json:"location"’
	Holder string ‘json:"holder"’
}
`

### Invoke Method

As described earlier, the **Invoke** method is the one which gets called when a transaction is proposed by a client application. Within this method, we have three different types of transactions -- _recordTuna_, _queryTuna_, and _changeTunaHolder_, which we will look at a little later.

As a reminder, Sarah, the fisherman, will invoke the _recordTuna_ when she catches each tuna.

![Invoke method - recordTuna](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/fa83f00cd04e8ba4e25d6cfb6035233e/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Invoke_method_recordTuna.png)

_changeTunaHolder_ can be invoked by Miriam, the restaurateur, when she confirms receiving and passing on a particular tuna fish as it passes through the supply chain. _queryTuna_ can be invoked by Miriam, the restaurateur, to view the state of a particular tuna.

![Invoke method - changeTunaHolder and queryTuna](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/1e43b46e9a6be77ffbd921e182d03e9d/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Invoke_method_queryTuna_and_changeTuna.png)

Regulators will invoke _queryTuna_ and _queryAllTuna_ based on their need to verify and check for sustainability of the supply chain.

![Invoke method - queryTuna and queryAllTuna](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/47cd6304d0e5df20df297e5b322cdf73/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Invoke_method_queryTuna_and_queryAllTuna.png)

We’ll be getting into the different tuna chaincode methods in the following sections. But here is the **Invoke** method. As you can see, this method will look at the first parameter to determine which function should be called, and invoke the appropriate tuna chaincode method.

`
func (s *SmartContract) Invoke(APIstub shim.ChaincodeStubInterface) sc.Response {
	// Retrieve the requested Smart Contract function and arguments
	function, args := APIstub.GetFunctionAndParameters()
	// Route to the appropriate handler function to interact with the ledger appropriately
	if function == "queryTuna" {
		return s.queryTuna(APIstub, args)
	} else if function == "initLedger" {
		return s.initLedger(APIstub)
	} else if function == "recordTuna" {
		return s.recordTuna(APIstub, args)
	} else if function == "queryAllTuna" {
		return s.queryAllTuna(APIstub)
	} else if function == "changeTunaHolder" {
		return s.changeTunaHolder(APIstub, args)
	}
	return shim.Error("Invalid Smart Contract function name.")
}
`

### Chaincode Methods - queryTuna

The _queryTuna_ method would be used by a fisherman, regulator, or restaurateur to view the record of one particular tuna. It takes one argument - the key for the tuna in question.

`
func (s *SmartContract) queryTuna(APIstub shim.ChaincodeStubInterface, args \[\]string) sc.Response {
	if len(args) != 1 {
		return shim.Error("Incorrect number of arguments. Expecting 1")
	}
	tunaAsBytes, _ := APIstub.GetState(args\[0\])
	if tunaAsBytes == nil {
		return shim.Error(“Could not locate tuna”)
	}
	return shim.Success(tunaAsBytes)
}
`

### Chaincode Methods - initLedger

The _initLedger_ method will add test data to our network.

`
func (s *SmartContract) initLedger(APIstub shim.ChaincodeStubInterface) sc.Response {
	tuna := \[\]Tuna{
	Tuna{Vessel: "923F", Location: "67.0006, -70.5476", Timestamp: "1504054225", Holder: "Miriam"},
	Tuna{Vessel: "M83T", Location: "91.2395, -49.4594", Timestamp: "1504057825", Holder: "Dave"},
	Tuna{Vessel: "T012", Location: "58.0148, 59.01391", Timestamp: "1493517025", Holder: "Igor"},
	Tuna{Vessel: "P490", Location: "-45.0945, 0.7949", Timestamp: "1496105425", Holder: "Amalea"},
	Tuna{Vessel: "S439", Location: "-107.6043, 19.5003", Timestamp: "1493512301", Holder: "Rafa"},
	Tuna{Vessel: "J205", Location: "-155.2304, -15.8723", Timestamp: "1494117101", Holder: "Shen"},
	Tuna{Vessel: "S22L", Location: "103.8842, 22.1277", Timestamp: "1496104301", Holder: "Leila"},
	Tuna{Vessel: "EI89", Location: "-132.3207, -34.0983", Timestamp: "1485066691", Holder: "Yuan"},
	Tuna{Vessel: "129R", Location: "153.0054, 12.6429", Timestamp: "1485153091", Holder: "Carlo"},
	Tuna{Vessel: "49W4", Location: "51.9435, 8.2735", Timestamp: "1487745091", Holder: "Fatima"},
	}
	i := 0
	for i < len(tuna) {
		fmt.Println("i is ", i)
		tunaAsBytes, _ := json.Marshal(tuna\[i\])
		APIstub.PutState(strconv.Itoa(i+1), tunaAsBytes)
		fmt.Println("Added", tuna\[i\])
		i = i + 1
	}
	return shim.Success(nil)
}
`

### Chaincode Methods - recordTuna

The _recordTuna_ method is the method a fisherman like Sarah would use to record each of her tuna catches. This method takes in five arguments (attributes to be saved in the ledger).

`
func (s *SmartContract) recordTuna(APIstub shim.ChaincodeStubInterface, args \[\]string) sc.Response {
	if len(args) != 5 {
		return shim.Error("Incorrect number of arguments. Expecting 5")
	}
	var tuna = Tuna{ Vessel: args\[1\], Location: args\[2\], Timestamp: args\[3\], Holder: args\[4\]}
	tunaAsBytes, _ := json.Marshal(tuna)
	err := APIstub.PutState(args\[0\], tunaAsBytes)
	if err != nil {
		return shim.Error(fmt.Sprintf("Failed to record tuna catch: %s", args\[0\]))
	}
	return shim.Success(nil)
}
`

### Chaincode Methods - queryAllTuna

The _queryAllTuna_ method allows for assessing all the records; in this case, all the Tuna records added to the ledger. This method does not take any arguments. It will return a JSON string containing the results.

`
func (s *SmartContract) queryAllTuna(APIstub shim.ChaincodeStubInterface) sc.Response {
startKey := "0"
endKey := "999"
resultsIterator, err := APIstub.GetStateByRange(startKey, endKey)
if err != nil {
return shim.Error(err.Error())
}
defer resultsIterator.Close()
// buffer is a JSON array containing QueryResults
var buffer bytes.Buffer
buffer.WriteString("\[")
bArrayMemberAlreadyWritten := false
for resultsIterator.HasNext() {
queryResponse, err := resultsIterator.Next()
if err != nil {
return shim.Error(err.Error())
}
// Add a comma before array members, suppress it for the first array member
if bArrayMemberAlreadyWritten == true {
buffer.WriteString(",")
}
buffer.WriteString("{\\"Key\\":")
buffer.WriteString("\\"")
buffer.WriteString(queryResponse.Key)
buffer.WriteString("\\"")
buffer.WriteString(", \\"Record\\":")
// Record is a JSON object, so we write as-is
buffer.WriteString(string(queryResponse.Value))
buffer.WriteString("}")
bArrayMemberAlreadyWritten = true
}
buffer.WriteString("\]")
fmt.Printf("- queryAllTuna:\\n%s\\n", buffer.String())
return shim.Success(buffer.Bytes())
}
`

### Chaincode Methods - changeTunaHolder

As the tuna fish is passed to different parties in the supply chain, the data in the world state can be updated with who has possession. The _changeTunaHolder_ method takes in 2 arguments, **tuna id** and **new holder name**.

`
func (s *SmartContract) changeTunaHolder(APIstub shim.ChaincodeStubInterface, args \[\]string) sc.Response {
	if len(args) != 2 {
		return shim.Error("Incorrect number of arguments. Expecting 2")
	}
	tunaAsBytes, _ := APIstub.GetState(args\[0\])
	if tunaAsBytes != nil {
		return shim.Error("Could not locate tuna")
	}
	tuna := Tuna{}
	json.Unmarshal(tunaAsBytes, &tuna)
	// Normally check that the specified argument is a valid holder of tuna but here we are skipping this check for this example.
	tuna.Holder = args\[1\]
	tunaAsBytes, _ = json.Marshal(tuna)
	err := APIstub.PutState(args\[0\], tunaAsBytes)
	if err != nil {
		return shim.Error(fmt.Sprintf("Failed to change tuna holder: %s", args\[0\]))
	}
	return shim.Success(nil)
}
`

### Conclusion

We hope you now have a better idea of how chaincode is constructed and written, especially when applied to a simple example. To see all the code snippets, visit the educational GitHub repository: [https://github.com/hyperledger/education/blob/master/LFS171x/fabric-material/chaincode/tuna-app/tuna-chaincode.go](https://github.com/hyperledger/education/blob/master/LFS171x/fabric-material/chaincode/tuna-app/tuna-chaincode.go).

## Writing an Application

### What Is a Blockchain Application?

In a blockchain application, the blockchain will store the state of the system, in addition to the immutable record of transactions that created that state. A client application will be used to send transactions to the blockchain. The smart contracts will encode some (if not all) of the business logic.

### How Applications Interact with the Network

Applications use APIs to run smart contracts. In Hyperledger Fabric, these smart contracts are called chaincode. These contracts are hosted on the network, and identified by name and version. APIs are accessible with a software development kit, or SDK. Currently, Hyperledger Fabric has three options for developers: Node.js SDK, Java SDK, and CLI.

### Fabric Node.js SDK

In this exercise, we will be using the Node.js SDK ([https://fabric-sdk-node.github.io/](https://fabric-sdk-node.github.io/)) to interact with the network, and, therefore, the ledger. The Hyperledger Fabric Client SDK makes it easy to use APIs to interact with a Hyperledger Fabric blockchain. This section will help you write your first application, starting with a test Hyperledger Fabric network, then learning the parameters of the sample smart contract, and lastly, developing the application to query and update ledger records.

For additional information, visit the Hyperledger Fabric Node SDK  documentation: [https://fabric-sdk-node.github.io/tutorial-app-dev-env-setup.html](https://fabric-sdk-node.github.io/tutorial-app-dev-env-setup.html).

### Hyperledger Fabric Tuna Application 

The tuna application is going to demonstrate the creation and transfer of tuna fish shipments between actors leveraging Hyperledger Fabric in the supply chain.

The application will be written in Node.js. The chaincode that we will be using is the demonstrated scenario chaincode that we walked through in the previous section. Interacting with the chaincode is done by using the gRPC protocol to a peer on the network. The details of the gRPC protocol are taken care of by the Hyperledger Fabric Client Node.js SDK.

### Getting Started 

In case you haven’t downloaded the **education** repository for this course, follow the below directions in your terminal window:

* $ git clone https://github.com/hyperledger/education.git
* $ cd education/LFS171x/fabric-material/tuna-app

Make sure you have Docker running on your machine before you run the next command. If you do not have Docker installed, return to Chapter 4, _Technical Requirements_.

Also, make sure that you have completed the _Installing Hyperledger Fabric_ section in this chapter before moving on to this application section, as you will likely experience errors. 

First, remove any pre-existing containers, as it may conflict with commands in this tutorial: **$ docker rm -f $(docker ps -aq)**

Then, let’s start the Hyperledger Fabric network with the following command: **$ ./startFabric.sh**

**Troubleshooting:** If, after running the above you are getting an error similar to the following:

**ERROR: failed to register layer: rename  
****/var/lib/docker/image/overlay2/layerdb/tmp/write-set-091347846 /var/lib/docker/image/overlay2/layerdb/sha256/9d3227c1793b7494e598caafd0a5013900e17dcdf1d7bdd31d39c82be04fcf28: file exists**

Try running the following command: **$ rm -rf ~/Library/Containers/com.docker.docker/Data/***

Install the required libraries from the **package.json** file, register the **Admin** and **User** components of our network, and start the client application with the following commands:

+ $ npm install
+ $ node registerAdmin.js
+ $ node registerUser.js
+ $ node server.js

Load the client simply by opening **localhost:8000** in any browser window of your choice, and you should see the user interface for our simple application at this URL (as in the screenshot below).

![The Fabric application user interface](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/50068889079cd063e30d8bbd6d5fe554/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/fabric-application1.png)

**Troubleshooting:** If you are getting an error similar to the one below while attempting to perform any of the functions on the application:

**Error: \[client-utils.js\]: sendPeersProposal - Promise is rejected: Error: Connect Failed**

**error from query =  { Error: Connect Failed**

**  at /Desktop/prj/education/LFS171x/fabric-material/tuna-app/node\_modules/grpc/src/node/src/client.js:554:15 code: 14, metadata: Metadata { \_internal_repr: {} } }**

try running the following commands:

+ $ cd ~
+ $ rm -rf .hfc-key-store/

Then, run the commands above starting with: **$ node registerAdmin.js**

### File Structure of Application

Here you can see the file structure of the Fabric application:

![The file structure of the Fabric application](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/a4867e651f3bb639e579fb3424bd9a62/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/fabric-filestructure.png)

### Query All Tuna Recorded

1. // queryAllTuna - requires no arguments
2. const request = {
3.     chaincodeId:’tuna-app’,
4.     txId: tx_id,
5.     fcn: 'queryAllTuna',
6.     args: \[''\]
7.     };
8. return channel.queryByChaincode(request);

(Reference: The code comes from **..src/queryAllTuna.js**)

Now, let’s query our database, where there should be some sample entries already, since our chaincode smart contract initiated the ledger with 10 previous catches. This function takes no arguments, as we see on line 6. Instead, it takes an empty array.

The query response you should see in the user interface is 10 pre-populated entries with the attributes for each catch.

![Fabric application - query all tuna recorded](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/ae31eb58789457980ae55a97aaee0aa8/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/fabric-queryAll.png)

### Query a Specific Tuna Recorded

1.  // queryTuna - requires 1 argument
2.  const request = {
3.      chaincodeId:’tuna-app’,
4.      txId: tx_id,
5.      fcn: 'queryTuna',
6.      args: \['1'\]
7.      };
8.  return channel.queryByChaincode(request);

(Reference: The code comes from **..src/queryTuna.js**)

Now, let’s query for a specific tuna catch. This function takes 1 argument, as you can see on line 6 above, an example would be **\['1'\]**. In this example, we are using the key to query for catches.

You should see the following query response detailing the attributes recorded for one particular catch.

![Fabric application query a specific tuna](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/4dbe39c61232ff1bfa939703cf396503/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/fabric-query.png)

### Change Tuna Holder
------------------

Bookmark this page

1.  // changeTunaHolder - requires 2 argument
2.  var request = {
3.      chaincodeId:’tuna-app’,
4.  fcn: 'changeTunaHolder',*
5.  args: \['1', 'Alex'\],
6.            chainId: 'mychannel',
7.            txId: tx_id
8.  };
9.  return channel.sendTransactionProposal(request);

(Reference: The code comes from **..src/changeHolder.js**)

Now, let’s change the name of the person in possession of a given tuna. This function takes 2 arguments: the key for the particular catch, and the new holder, as we can see on line 5 in the example above. Ex: **args: \['1', 'Alex'\]**.

You may be able to see a similar success response in your terminal window:

**The transaction has been committed on peer localhost:7053  
**** event promise all complete and testing complete**

**Successfully sent transaction to the orderer.  
****Successfully sent Proposal and received ProposalResponse: Status - 200, message - "OK", metadata - "", endorsement signature: 0D 9**

This indicates we have sent a proposal from our application via the SDK, and the peer has been endorsed, committed, and the ledger has been updated.

![Fabric application change tuna holder](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/e36aee4cc0c801b18e855eb1fc234c4b/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/fabric-changeTunaHolder.png)

You should see that the holder has indeed been changed by querying for key **\['1'\]** again. Now, the **holder** attribute has been changed from **Miriam** to **Alex**, for example.

![Fabric application change record](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/c43d7a8103c74fc3c8a0e123889d02ab/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/fabric-changedRecord.png)

### Finishing Up

Remove all Docker containers and images that we created in this tutorial with the following command in the **tuna-app** folder:

+ **$ docker rm -f $(docker ps -aq)**
+ **$ docker rmi -f $(docker images -a -q)**

### Application Flow Basics

![Fabric application flow basics](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/a63eaf4dd007c3e65ee63955eccaf5b6/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/fabric-application-flowbasics.png)

1.  A developer creates an application and smart contract.
2.  The application will invoke calls within the smart contract via the Hyperledger Fabric Client SDK.
3.  These calls are processed by the business logic within the chaincode smart contract.
4.  A **put** or **delete** command will go through the consensus process and will be added to the blockchain within the ledger.
5.  A **get** command can only read from the world state, but it is not recorded on the blockchain.
6.  The application can access blockchain information via APIs.

### Application Flow Example

![Fabric application flow example](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/f01702e7429e967987a62daf274a164b/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/fabric-application-flow.png)

1.  Various users (fisherman, regulators, or restaurateurs etc.) will interact with the Node.js application.
2.  The client JS will send messages to the backend when the user interacts with the application.
3.  Reading or writing the ledger is known as a proposal (for example, querying a specific Tuna catch - **queryTuna**-  or recording a tuna catch - **recordTuna**). This proposal is built by our application via the SDK, and then sent to the endorsing peers.
4.  The endorsing peers will use the application-specific chaincode smart contract to simulate the transaction. If there are no issues, the transaction will be endorsed, and sent back to our application.
5.  Our application will then send the endorsed proposal to the ordering service via the SDK. The orderer will package many proposals from the whole network into a block. Then, it will broadcast the new block to the committing peers in the network.
6.  Finally, each committing peer will validate the block and write it to its ledger (shown in teal above). The transaction has now been committed, and any reads will reflect this change.

## Joining the Hyperledger Fabric Community

### Becoming Involved with the Hyperledger Fabric Project

Hyperledger Fabric is an open source project, where ideas and code can be publicly discussed, created, and reviewed. There are many ways to join the Hyperledger Fabric community. Next, we will highlight some of the ways to get involved, either from a technical standpoint, or from an ideas/issues creation perspective.

### Community Meetings and Mailing Lists

You can join the the weekly meeting on Fabric Documentation, or other Hyperledger Fabric-related meetings. The [Hyperledger Community Meetings Calendar](https://calendar.google.com/calendar/embed?src=linuxfoundation.org_nf9u64g9k9rvd9f8vp4vur23b0%40group.calendar.google.com&ctz=America/SanFrancisco) is a great resource to learn the timing for these meetings.

You can join the Hyperledger Fabric mailing lists for technical discussions and announcements:  [https://lists.hyperledger.org/mailman/listinfo/hyperledger-fabric](https://lists.hyperledger.org/mailman/listinfo/hyperledger-fabric).

### JIRA and Gerrit

If you have a bug to report, you can submit an issue using JIRA (you must have a Linux Foundation ID to access JIRA): [https://jira.hyperledger.org/secure/Dashboard.jspa?selectPageId=10104](https://jira.hyperledger.org/secure/Dashboard.jspa?selectPageId=10104). You can also find and review a list of existing issues, and can pick one that interests you and start working on it: [https://jira.hyperledger.org/browse/FAB-5491?filter=10580](https://jira.hyperledger.org/browse/FAB-5491?filter=10580). You can learn how to use the JIRA documentation at [https://wiki.hyperledger.org/community/jira-navigation](https://wiki.hyperledger.org/community/jira-navigation).

Gerrit is used for submitting PRs and managing code reviews and checkins. All code is forkable and viewable: [https://gerrit.hyperledger.org/r/#/admin/projects/](https://gerrit.hyperledger.org/r/#/admin/projects/). You can get a primer on working with Gerrit at [https://hyperledger-fabric.readthedocs.io/en/latest/Gerrit/gerrit.html](https://hyperledger-fabric.readthedocs.io/en/latest/Gerrit/gerrit.html).

### Rocket.Chat

You can join the live conversations on Rocket.Chat (which is an alternative to Slack), using your Linux Foundation ID: [https://chat.hyperledger.org/home](https://chat.hyperledger.org/home). There are over 24 channels specific to the Hyperledger Fabric project. The [#fabric](https://chat.hyperledger.org/channel/fabric) channel is used to discuss the Hyperlerdger Fabric project. You can find a guide for these channels here: [https://wiki.hyperledger.org/community/chat_channels](https://wiki.hyperledger.org/community/chat_channels).

# Chapter 8. What's Next?

## What's Next?

### Hyperledger Community

The development of the Hyperledger projects is led by a diverse group of technical, open source contributors. We are always looking for help to build an open source ecosystem of business blockchain technologies. If you are interested in contributing to and learning from the community, we welcome you to [join the Hyperledger effort](https://www.hyperledger.org/community).

### Joining the Hyperledger Community

You too can join the Hyperledger Community:

*   **For developers**  
    Read the Hyperledger code on [GitHub](https://github.com/hyperledger/hyperledger). Join the Hyperledger discussion at [Rocket.Chat](https://chat.hyperledger.org/home). Search for open bugs, or report a new one in the [Hyperledger’s bug database](https://jira.hyperledger.org/secure/Dashboard.jspa).
*   **For business leaders**  
    For key updates from Hyperledger, join the [mailing list](https://lists.hyperledger.org/mailman/listinfo). Explore all Hyperledger [business solutions](https://www.hyperledger.org/projects).
*   **For educators and community leaders**  
    You can start or join a [Hyperledger meetup](https://www.meetup.com/pro/hyperledger/). Development updates from Wiki can be found [here](https://wiki.hyperledger.org/).

![Hyperledger Global Meetups](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/9f346d9125ac62f4462d898aa9e172ac/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Hyperledger_Global_Meetups.png)

### Hyperledger Working Groups

The Hyperledger Community’s working groups are open to the public. Developers and tech leaders can engage with any of the Hyperledger’s open community channels at this [page](https://github.com/hyperledger/hyperledger/wiki/PublicMeetingCalendar).

Below, you can see an overview of Hyperledger’s working groups.

![Hyperledger Working Groups](https://prod-edxapp.edx-cdn.org/assets/courseware/v1/cca8220e1d574e52f989fd518d54d5fb/asset-v1:LinuxFoundationX+LFS171x+3T2017+type@asset+block/Hyperledger_Working_Groups.png)

### Conclusions

This concludes the _Blockchain for Business: An Introduction to Hyperledger Technologies_ course! We have introduced you to the current Hyperledger frameworks and modules, we have highlighted some of the business blockchain applications, we have guided you through a more in-depth tour on three of the most mature frameworks (Hyperledger Iroha, Hyperledger Sawtooth, and Hyperledger Fabric), and we also provided deep-dive tutorials for Hyperledger Sawtooth and Hyperleger Fabric.

We hope this course inspires you and helps you continue your journey into the business blockchain technology world. Whether you are an engineer, entrepreneur, developer, educator, or business person, we look forward to seeing what you build, as well as hearing from you in the course forum. 

Good luck to all of you in your future endeavors! 

# Glossary

On this page, we will have a list of the key concepts that are used in this course, and their definitions, that will help you when going through the course content. These definitions will be quickly accessible from anywhere within the course, just click on the **Glossary** tab.

**Block** \- A set of transactions that are bundled together and added to the chain at the same time.

**Byzantine Fault Tolerance Algorithm** \- A consensus algorithm designed to defend against failures in the system caused by forged or malicious messages. In order to be fault tolerant of a Byzantine fault, the number of nodes that must reach consensus is _**2f+1**_ in a system containing _**3f+1**_, where _**f**_ is the number of faults in the system. 

**Chaincode** \- Smart contracts in Hyperledger Fabric. They encapsulate both the asset definitions and the business logic (or transactions) for modifying those assets.

**Consensus Algorithm** \- Refers to a system of ensuring that parties agree to a certain state of the system as the true state.

**Cryptocurrency** \- is a digital asset that is used as a medium of exchange. A cryptocurrency is exchanged by using digital signatures to transfer ownership from one cryptographic key pair to another key pair. Since this digital asset has characteristics of money (like store of value and medium of exchange), it is generally referred to as currency. _Note:_ It should not be confused with digital currency or virtual currency.

**Cryptoeconomics** \- A field of study that explores the intersection of cryptography and economic incentives. While cryptography is used for ensuring network security at various levels and functions, the built-in economic incentives provided to the participating nodes in the network ensure that, at any given point, the majority of players in the network operate in a desirable way. 

**Cryptography** \- The study of the techniques used to allow secure communication between different parties, and to ensure the authenticity and immutability of the data being communicated.

**Distributed Ledger** \- A type of data structure which resides across multiple computer devices, generally spread across locations and regions.

**Hash Function** \- It is used to map data of any size to a fixed length. The output of a hash function is referred to as a hash, hash value, or digest. One important characteristic of a hash function is that, when given a specific input, the hash function will always produce the exact same output.

**Key/Value Pair** \- It consists of two parts, one designated as a 'key', and another as a 'value'. The 'key' is an identifier that allows you to look up the 'value'. The 'value' is the data that is stored for a given 'key'.

**Mining** \- The process of solving computational challenging puzzles in order to create new blocks in the Bitcoin blockchain.

**Node** \- Computer device attached to a blockchain network. Types of nodes include: mining nodes, validator nodes, committer nodes, and endorser nodes. Nodes are sometimes also called 'peers' because they make up the devices within a peer-to-peer network.

**Peer-to-Peer Network** \- A network witch consists of computer systems which are directly connected to each other via the Internet without a central server.

**Private/Public Keys** \- Private keys are used to derive a public key. While private keys remain confidential, public keys are available to everyone in the network (similar to an email address). Anything encrypted with a public key can only be decrypted using its corresponding private key, and vice versa. 

**Proof of Elapsed Time (PoET)** \- Consensus algorithm used by Hyperledger Sawtooth that utilizes a lottery function in which the node with the shortest wait time creates the next block. 

**Proof of Stake (PoS)** \- Consensus algorithm where nodes are randomly selected to validate blocks, and the probability of this random selection depends on the amount of stake held.

**Proof of Work (PoW)** \- Consensus algorithm first utilized by Bitcoin that involves solving a computational challenging puzzle in order to create a new block.

**Smart Contract** \- Computer program that executes predefined actions when certain conditions within the system are met. Smart contracts were first proposed by Nick Szabo in 1996 ([http://www.fon.hum.uva.nl/rob/Courses/InformationInSpeech/CDROM/Literature/LOTwinterschool2006/szabo.best.vwh.net/smart\_contracts\_2.html](http://www.fon.hum.uva.nl/rob/Courses/InformationInSpeech/CDROM/Literature/LOTwinterschool2006/szabo.best.vwh.net/smart_contracts_2.html)).

**State** \- Contains up-to-date data that represents the latest values for all keys included in the network's ledger. The state of a network encompasses all past transactions in the network, from the genesis block to the present time.

**Transaction** \- A record of an event, cryptographically secured with a digital signature, that is verified, ordered, and bundled with other such records into blocks. 

**Transaction Families** \- Smart contracts in Hyperledger Sawtooth. They define the operations that can be applied to transactions. Transaction families consist of both transaction processors (the server-side logic) and clients (for use from web or mobile applications).

**Turing-Complete** \- Named after Alan Turing, an English mathematician and computer scientist, it refers to a computer that can solve any problem that a Turing Machine can. A Turing Machine is a machine that can simulate any computer algorithm, no matter how complicated. Bitcoin scripting language is not Turing-Complete, as there are no looping and branching types of computing sequences. Ethereum's Solidity language is considered Turing-Complete, as it does have looping and branching.

# Recommended Resources

### Chapter 1. Discovering Blockchain Technologies

+   Muneeb Ali, _The next wave of computing, medium_ - [https://medium.com/@muneeb/the-next-wave-of-computing-743295b4bc73](https://medium.com/@muneeb/the-next-wave-of-computing-743295b4bc73)
+   Hyperledger Sawtooth documentation - [https://sawtooth.hyperledger.org/docs/core/releases/latest/introduction.html](https://sawtooth.hyperledger.org/docs/core/releases/latest/introduction.html)
+   Hyperledger website - [https://hyperledger.org/about](https://hyperledger.org/about)
+   Vinay Gupta, _A Brief History of Blockchain_ - [https://hbr.org/2017/02/a-brief-history-of-blockchain](https://hbr.org/2017/02/a-brief-history-of-blockchain)
+   Andreas M. Antonopoulos, _Mastering Bitcoin: Unlocking Digital Cryptocurrencies_ - [http://chimera.labs.oreilly.com/books/1234000001802/ch07.html#\_structure\_of\_a\_block)](http://chimera.labs.oreilly.com/books/1234000001802/ch07.html#_structure_of_a_block))
+   Bettina Warburg, _How the blockchain will radically transform the economy_ - [https://www.ted.com/talks/bettina\_warburg\_how\_the\_blockchain\_will\_radically\_transform\_the_economy](https://www.ted.com/talks/bettina_warburg_how_the_blockchain_will_radically_transform_the_economy) 
+   WEF, _The Global Risks Report 2016_ - [https://www.weforum.org/reports/the-global-risks-report-2016](https://www.weforum.org/reports/the-global-risks-report-2016)
+   Antony Lewis, _A gentle introduction to immutability of blockchains_ - [https://www.linkedin.com/pulse/gentle-introduction-immutability-blockchains-antony-lewis/](https://www.linkedin.com/pulse/gentle-introduction-immutability-blockchains-antony-lewis/)
+   Elena Mesropyan, _21 Companies Leveraging Blockchain for Identity Management and Authentication_ - [https://letstalkpayments.com/22-companies-leveraging-blockchain-for-identity-management-and-authentication/](https://letstalkpayments.com/22-companies-leveraging-blockchain-for-identity-management-and-authentication/)
+   Daniel Palmer, _7 Cool Decentralized Apps Being Built on Ethereum_ - [https://www.coindesk.com/7-cool-decentralized-apps-built-ethereum/](https://www.coindesk.com/7-cool-decentralized-apps-built-ethereum/)
+   Cryptocurrency Market Capitalizations (Bitcoin) - [https://coinmarketcap.com/currencies/bitcoin/](https://coinmarketcap.com/currencies/bitcoin/)
+   _Eight Things Cryptocurrency Enthusiasts Probably Won't Tell You_ - [http://www.ofnumbers.com/2017/09/21/eight-things-cryptocurrency-enthusiasts-probably-wont-tell-you/](http://www.ofnumbers.com/2017/09/21/eight-things-cryptocurrency-enthusiasts-probably-wont-tell-you/)
+   AngelList - Blockchain Startups - [https://angel.co/blockchains](https://angel.co/blockchains)
+   Vitalik Buterin, _Introduction to Cryptoeconomics_ - [https://www.youtube.com/watch?v=pKqdjaH1dRo](https://www.youtube.com/watch?v=pKqdjaH1dRo)
+   Navroop Sahdev,_The Tokenization of the Economy: ICOs and the implications for Cryptoeconomics_, Coala Working Paper, 2017
+   Chris Berg, Sinclair Davidson and Jason Potts, _The Blockchain Economy: A beginner's guide to institutional cryptocurrencies_ - [https://medium.com/@cryptoeconomics/the-blockchain-economy-a-beginners-guide-to-institutional-cryptoeconomics-64bf2f2beec4](https://medium.com/@cryptoeconomics/the-blockchain-economy-a-beginners-guide-to-institutional-cryptoeconomics-64bf2f2beec4)
+   Crypocurrency Market Capitalizations (Ethereum) - [https://coinmarketcap.com/currencies/ethereum/](https://coinmarketcap.com/currencies/ethereum/)
+   Stephan Tual, _What is Ethereum_ - [https://www.youtube.com/watch?v=Clw-qf1sUZg](https://www.youtube.com/watch?v=Clw-qf1sUZg)
+   Ethereum Documentation - [http://www.ethdocs.org/en/latest/introduction/web3.html](http://www.ethdocs.org/en/latest/introduction/web3.html)
+   Augur - [https://augur.net/](https://augur.net/)
+   Digix - [https://digix.global/](https://digix.global/)
+   Maker - [https://makerdao.com/](https://makerdao.com/)
+   RSK - [http://www.rsk.co/](http://www.rsk.co/)
+   JP Aumasson and Phillipp Jovanovic, _Blockchains in 2016: status quo and scaling challenges_ - [https://www.kudelskisecurity.com/sites/default/files/files/kudelski\_Security\_blockchain_20161213.pdf](https://www.kudelskisecurity.com/sites/default/files/files/kudelski_Security_blockchain_20161213.pdf)
+   Ofir Beigel, _what is Proof of Work/Proof of Stake ?_ - [https://99bitcoins.com/proof-of-work-proof-of-stake/](https://99bitcoins.com/proof-of-work-proof-of-stake/)
+   Satyakam Chakravarty, _Blockchain consensus algorithm: Proof-of-Work to Proof-of-Stake_ - [https://www.linkedin.com/pulse/blockchain-consensus-algorithm-proof-of-work-satyakam-chakravarty/](https://www.linkedin.com/pulse/blockchain-consensus-algorithm-proof-of-work-satyakam-chakravarty/)
+   bitcoinwiki, _Proof of burn_ - [https://en.bitcoin.it/wiki/Proof\_of\_burn](https://en.bitcoin.it/wiki/Proof_of_burn) 
+   Adrian Colyer, _Practical Byzantine Fault Tolerance_ - [https://blog.acolyer.org/2015/05/18/practical-byzantine-fault-tolerance/](https://blog.acolyer.org/2015/05/18/practical-byzantine-fault-tolerance/)
+   Phillipp Jovanovic, _ByzCoin: Securely Scaling Blockchains_ - [http://hackingdistributed.com/2016/08/04/byzcoin/](http://hackingdistributed.com/2016/08/04/byzcoin/)
+   _Hyperledger Architecture, Volume 1_ - [https://www.hyperledger.org/wp-content/uploads/2017/08/HyperLedger\_Arch\_WG\_Paper\_1_Consensus.pdf](https://www.hyperledger.org/wp-content/uploads/2017/08/HyperLedger_Arch_WG_Paper_1_Consensus.pdf)
+   Amy Castor, _A (Short) Guide to Blockchain Consensus Protocols_ - [https://www.coindesk.com/short-guide-blockchain-consensus-protocols/](https://www.coindesk.com/short-guide-blockchain-consensus-protocols/)
+   _Consensus achieved using Proof-of-Work_ - [https://mastanbtc.github.io/blockchainnotes/consensustypes/](https://mastanbtc.github.io/blockchainnotes/consensustypes/)
+   Chain Core - [https://chain.com/technology/](https://chain.com/technology/)
+   Richard Gendal Brown, _Introducing R3 Corda™: A Distributed Ledger Designed for Financial Services_ - [http://www.r3cev.com/blog/2016/4/4/introducing-r3-corda-a-distributed-ledger-designed-for-financial-services](http://www.r3cev.com/blog/2016/4/4/introducing-r3-corda-a-distributed-ledger-designed-for-financial-services)
+   Corda - [https://www.corda.net/](https://www.corda.net/)
+   Quorum - [https://www.jpmorgan.com/country/US/EN/Quorum](https://www.jpmorgan.com/country/US/EN/Quorum)
+   Martin Rosulek, How IOTA makes bright future for Internet of Things - [https://medium.com/@MartinRosulek/how-iota-makes-future-for-internet-of-things-af14fd77d2a3](https://medium.com/@MartinRosulek/how-iota-makes-future-for-internet-of-things-af14fd77d2a3)
+   Roger Aitken, _IOTA's Bitfinex Listing Surges To $1.5B Record-Breaking 'Crypto' Capitalization On Market Debut_ - [https://www.forbes.com/sites/rogeraitken/2017/06/15/iotas-bitfinex-listing-surges-to-1-5b-record-breaking-crypto-capitalization-on-market-debut/#6cf94dbd75a5](https://www.forbes.com/sites/rogeraitken/2017/06/15/iotas-bitfinex-listing-surges-to-1-5b-record-breaking-crypto-capitalization-on-market-debut/#6cf94dbd75a5)
+   Advait Deshpande, Katherine Stewart, Louise Lepetit, Salil Gunashekar, _Distributed Ledger Technologies/Blockchain: Challenges, opportunities and the prospects for standards_ - [https://www.bsigroup.com/PageFiles/508003/BSI\_Blockchain\_DLT_Web.pdf](https://www.bsigroup.com/PageFiles/508003/BSI_Blockchain_DLT_Web.pdf)
+   Clare Naden, [Blockchain technology set to grow further with international standards in pipeline](https://www.iso.org/news/Ref2188.htm) - [https://www.iso.org/news/Ref2188.htm](https://www.iso.org/news/Ref2188.htm)
+   ISO/TC 307, Blockchain and distributed ledger technologies - [https://www.iso.org/committee/6266604.html](https://www.iso.org/committee/6266604.html)
+   Navroop K. Sahdev, _Crowdfunding Meets Blockchain_ - [https://papers.ssrn.com/sol3/papers.cfm?abstract_id=3047682](https://papers.ssrn.com/sol3/papers.cfm?abstract_id=3047682)
+   SEC, _Investor Bulletin: Initial Coin Offerings_ (July 25, 2017) - [https://www.sec.gov/oiea/investor-alerts-and-bulletins/ib_coinofferings](https://www.sec.gov/oiea/investor-alerts-and-bulletins/ib_coinofferings)
+   Saheli Roy Choudhury, _China bans companies from raising money through ICOs, asks local regulators to inspect 60 major platforms_ - [https://www.cnbc.com/2017/09/04/chinese-icos-china-bans-fundraising-through-initial-coin-offerings-report-says.html](https://www.cnbc.com/2017/09/04/chinese-icos-china-bans-fundraising-through-initial-coin-offerings-report-says.html)
+   _Why Hyperledger?_ - [https://www.youtube.com/watch?v=dimE7DI6VLI](https://www.youtube.com/watch?v=dimE7DI6VLI)
+   Jeff John Roberts, _IBM-Backed Hyperledger Releases New Blockchain Code 'Fabric'_ - [http://fortune.com/2017/07/11/ibm-blockchain-hyperledger-fabric/](http://fortune.com/2017/07/11/ibm-blockchain-hyperledger-fabric/) 
+   _What makes the Hyperledger Project unique? - Developer Perspectives On Blockchain series_ - [https://www.youtube.com/watch?v=Y4Os5R-CMeg](https://www.youtube.com/watch?v=Y4Os5R-CMeg)
+   _Hyper Ledger pitch_ - [https://www.youtube.com/watch?v=wG-maoz01gM](https://www.youtube.com/watch?v=wG-maoz01gM)
+   _Hyperledger Fabric Demo_ - [https://www.youtube.com/watch?v=xgFthehLNJ4](https://www.youtube.com/watch?v=xgFthehLNJ4)
+   _An Introduction to Hyperledger Fabric and IBM Blockchain_ - [https://www.youtube.com/watch?v=JuXH9OYXcQQ](https://www.youtube.com/watch?v=JuXH9OYXcQQ)
+   Albert Szmigielski, _Distributed vs. Decentralized Networks_ - [http://blog.cryptoiq.ca/?p=26](http://blog.cryptoiq.ca/?p=26)
+   Ken Mafli, _Mega Data Breaches Could Drive the Blockchain Revolution_ - [https://www.infosecurity-magazine.com/opinions/data-breaches-blockchain-revolution/](https://www.infosecurity-magazine.com/opinions/data-breaches-blockchain-revolution/)
+   Ameer Rosic, _5 Blockchain Applications That Are Shaping Your Future_ - [https://www.huffingtonpost.com/ameer-rosic-/5-blockchain-applications\_b\_13279010.html](https://www.huffingtonpost.com/ameer-rosic-/5-blockchain-applications_b_13279010.html)
+   Vitalik Buterin, _The Meaning of Decentralization_ - [https://medium.com/@VitalikButerin/the-meaning-of-decentralization-a0c92b76a274](https://medium.com/@VitalikButerin/the-meaning-of-decentralization-a0c92b76a274)
+   CNBC, _Ethereum Vs. Bitcoin: What Sets Them Apart?_ - [https://www.youtube.com/watch?v=0UBk1e5qnr4](https://www.youtube.com/watch?v=0UBk1e5qnr4)
+   Brian Patrick Eha, _The race to connect smart contracts to the real world_ - [https://www.americanbanker.com/news/the-race-to-connect-smart-contracts-to-the-real-world](https://www.americanbanker.com/news/the-race-to-connect-smart-contracts-to-the-real-world)
+   Kyle Torpey, _Ethereum style smart contracts are coming to Bitcoin in June_ -[https://bravenewcoin.com/news/ethereum-style-smart-contracts-are-coming-to-bitcoin-in-june/](https://bravenewcoin.com/news/ethereum-style-smart-contracts-are-coming-to-bitcoin-in-june/)
+   Daniel Zakrisson, _If Code Should Be Law We Need Better Development Standards_ - [https://medium.com/iconominet/if-code-should-be-law-we-need-better-development-standards-19e28a3a15f2](https://medium.com/iconominet/if-code-should-be-law-we-need-better-development-standards-19e28a3a15f2)
+   Michael Mainelli, _Which Way for Blockchain Standards in 2017?_ - [https://www.coindesk.com/which-way-for-blockchain-standards-in-2017/](https://www.coindesk.com/which-way-for-blockchain-standards-in-2017/)

### Chapter 2. Introduction to Hyperledger

+   [https://www.hyperledger.org](https://www.hyperledger.org)
+   _Meet the TSC: Arnaud Le Hors, IBM_ - [https://www.hyperledger.org/blog/2017/09/12/3431](https://www.hyperledger.org/blog/2017/09/12/3431)
+   _Hyperledger Architecture, Volume 1_ - [https://www.hyperledger.org/wp-content/uploads/2017/08/HyperLedger\_Arch\_WG\_Paper\_1_Consensus.pdf](https://www.hyperledger.org/wp-content/uploads/2017/08/HyperLedger_Arch_WG_Paper_1_Consensus.pdf)
+   Hyperledger Fabric Documentation - [https://hyperledger-fabric.readthedocs.io/en/latest/](https://hyperledger-fabric.readthedocs.io/en/latest/)
+   John Palfreyman, _Open Innovation, blockchain & hyperledger_ - [https://www.ibm.com/blogs/insights-on-business/government/open-innovation-blockchain-hyperledger/](https://www.ibm.com/blogs/insights-on-business/government/open-innovation-blockchain-hyperledger/)
+   _ABCs of Open Governance_ - [https://hyperledger.org/blog/2017/09/06/abcs-of-open-governance](https://hyperledger.org/blog/2017/09/06/abcs-of-open-governance)
+   Hyperledger Iroha - [https://hyperledger.org/projects/iroha](https://hyperledger.org/projects/iroha)
+   _YAC: vote-based consensus algorithm for private blockchain_ - [https://www.overleaf.com/read/wzhwjzbjvrzn#/40115559/](https://www.overleaf.com/read/wzhwjzbjvrzn#/40115559/)
+   Hyperledger Sawtooth - [https://www.hyperledger.org/projects/sawtooth](https://www.hyperledger.org/projects/sawtooth)
+   Hyperledger Fabric - [https://www.hyperledger.org/projects/fabric](https://www.hyperledger.org/projects/fabric)
+   Breach Level Index - [http://breachlevelindex.com/](http://breachlevelindex.com/)
+   _Privacy by design_ - [https://en.wikipedia.org/wiki/Privacy\_by\_design](https://en.wikipedia.org/wiki/Privacy_by_design)
+   Hyperledger Indy - [https://sovrin.org/](https://sovrin.org/)
+   Hyperledger Burrow - [https://www.hyperledger.org/projects/hyperledger-burrow](https://www.hyperledger.org/projects/hyperledger-burrow)
+   Hyperledger Burrow - [https://monax.io/platform/db/](https://monax.io/platform/db/)
+   Hyperledger Cello - [https://www.hyperledger.org/projects/cello](https://www.hyperledger.org/projects/cello)
+   _Hyperledger Says Hello to Cello_ - [https://www.hyperledger.org/blog/2017/01/17/hyperledger-says-hello-to-cello](https://www.hyperledger.org/blog/2017/01/17/hyperledger-says-hello-to-cello)
+   Hyperledger Explorer - [https://www.hyperledger.org/projects/explorer](https://www.hyperledger.org/projects/explorer)
+   Hyperledger Composer - [https://www.hyperledger.org/projects/composer](https://www.hyperledger.org/projects/composer)
+   _Hyperledger Composer Overview_ - [https://www.hyperledger.org/wp-content/uploads/2017/05/Hyperledger-Composer-Overview.pdf](https://www.hyperledger.org/wp-content/uploads/2017/05/Hyperledger-Composer-Overview.pdf)
+   _Introduction to Hyperledger Composer_ - [https://www.youtube.com/watch?v=cNvOQp8r0xo](https://www.youtube.com/watch?v=cNvOQp8r0xo)
+   Hyperledger Fabric Youtube Playlist - [https://www.youtube.com/playlist?list=PL0MZ85B_96CH7wvtrRzV7SvtRY0sI0DEg](https://www.youtube.com/playlist?list=PL0MZ85B_96CH7wvtrRzV7SvtRY0sI0DEg)
+   Roger Strukhoff, _Hyperledger Incubation: Burrow Integrates Ethereum Virtual Machine_ - [https://www.altoros.com/blog/hyperledger-incubation-burrow-integrates-permissioned-ethereum-virtual-machine/](https://www.altoros.com/blog/hyperledger-incubation-burrow-integrates-permissioned-ethereum-virtual-machine/)
+   Carlo Gutierrez, _Hyperledger Meets Ethereum: Integration and the Future_ - [https://www.altoros.com/blog/hyperledger-meets-ethereum-integration-future/](https://www.altoros.com/blog/hyperledger-meets-ethereum-integration-future/)
+   _General Data Protection Regulation_, [https://en.wikipedia.org/wiki/General\_Data\_Protection_Regulation](https://en.wikipedia.org/wiki/General_Data_Protection_Regulation)
+   Drummond Reed, Jason Law, and Daniel Hardman, _The Technical Foundations of Sovrin_ - [https://sovrin.org/wp-content/uploads/2017/04/The-Technical-Foundations-of-Sovrin.pdf](https://sovrin.org/wp-content/uploads/2017/04/The-Technical-Foundations-of-Sovrin.pdf)
+   Phillip J. Windley, _How Sovrin Works_ - [https://sovrin.org/wp-content/uploads/2017/04/How-Sovrin-Works.pdf](https://sovrin.org/wp-content/uploads/2017/04/How-Sovrin-Works.pdf)
+   Roger Strukhoff, _Visualizing Blockchain Operations with Hyperledger Explorer_ - [https://www.altoros.com/blog/visualizing-blockchain-operations-with-hyperledger-explorer/](https://www.altoros.com/blog/visualizing-blockchain-operations-with-hyperledger-explorer/)
+   Ian Allison, _Hyperledger Project announces business blockchain Composer_ - [http://www.ibtimes.co.uk/hyperledger-project-announces-business-blockchain-composer-1619843](http://www.ibtimes.co.uk/hyperledger-project-announces-business-blockchain-composer-1619843)

### Chapter 3. The Promise of Business Blockchain Technologies

+   WTO, _Trade finance and SMEs: Bridging the gaps in provision_ - [https://www.wto.org/english/res\_e/booksp\_e/tradefinsme_e.pdf](https://www.wto.org/english/res_e/booksp_e/tradefinsme_e.pdf)
+   Karen Gilchrist, _Fake smartphone sales cost global industry $48 billion_ - [https://www.cnbc.com/2017/02/28/fake-smartphone-sales-cost-global-industry-48-billion.html](https://www.cnbc.com/2017/02/28/fake-smartphone-sales-cost-global-industry-48-billion.html)
+   Pamela Ambler, _China Is Facing An Epidemic Of Counterfeit And Contraband Wine_ - [https://www.forbes.com/sites/pamelaambler/2017/07/27/china-is-facing-an-epidemic-of-counterfeit-and-contraband-wine/#7e85a1325843](https://www.forbes.com/sites/pamelaambler/2017/07/27/china-is-facing-an-epidemic-of-counterfeit-and-contraband-wine/#7e85a1325843)
+   Laura Shin, _Republic Of Georgia To Pilot Land Titling On Blockchain With Economist Hernando De Soto, BitFury_ - [https://www.forbes.com/sites/laurashin/2016/04/21/republic-of-georgia-to-pilot-land-titling-on-blockchain-with-economist-hernando-de-soto-bitfury/#4686b55844da](https://www.forbes.com/sites/laurashin/2016/04/21/republic-of-georgia-to-pilot-land-titling-on-blockchain-with-economist-hernando-de-soto-bitfury/#4686b55844da)
+   _What is proof of existence?_ - [https://poex.io/about](https://poex.io/about)
+   Satoshi Nakamoto, _Bitcoin: A Peer-to-Peer Electronic Cash System_ - [https://bitcoin.org/bitcoin.pdf](https://bitcoin.org/bitcoin.pdf)
+   Guy Brandon, _Can the blockchain scale?_ - [https://due.com/blog/can-the-blockchain-scale/](https://due.com/blog/can-the-blockchain-scale/)
+   Lightning Network - [https://lightning.network/](https://lightning.network/)
+   NPP, _Federal Spending: Where Does the Money Go_ - [https://www.nationalpriorities.org/budget-basics/federal-budget-101/spending/](https://www.nationalpriorities.org/budget-basics/federal-budget-101/spending/)
+   ONC - [https://www.healthit.gov/](https://www.healthit.gov/)
+   Hyperledger Wiki, _Use Case Inventory_ - [https://wiki.hyperledger.org/groups/requirements/use-case-inventory](https://wiki.hyperledger.org/groups/requirements/use-case-inventory)
+   GitHub, Hyperledger Composer Sample Models - [https://github.com/hyperledger/composer-sample-models](https://github.com/hyperledger/composer-sample-models)
+   GitHub, Hyperledger Composer Sample Networks - [https://github.com/hyperledger/composer-sample-networks](https://github.com/hyperledger/composer-sample-networks)
+   IBM Blockchain, _Leverage blockchain to transform your business and disrupt your industry_ - [https://www.ibm.com/blockchain/for-business.html](https://www.ibm.com/blockchain/for-business.html)
+   Hyperledger Fabric Documentation, Use Cases - [http://hyperledger-fabric.readthedocs.io/en/latest/usecases.html](http://hyperledger-fabric.readthedocs.io/en/latest/usecases.html)
+   Kathryn Harrison and Simon Stone, _Accelerating Blockchain Development with Hyperledger Composer_ - [https://www.youtube.com/watch?v=iRlm4uY_9pA&t=204s](https://www.youtube.com/watch?v=iRlm4uY_9pA&t=204s)
+   Martin Valenta and Phillipp Sandner, _Comparison of Ethereum, Hyperledger Fabric and Corda_ - [https://medium.com/@philippsandner/comparison-of-ethereum-hyperledger-fabric-and-corda-21c1bb9442f6](https://medium.com/@philippsandner/comparison-of-ethereum-hyperledger-fabric-and-corda-21c1bb9442f6)

### Chapter 6. Introduction to Hyperledger Sawtooth

+   Nishan Degnarain, _Can technology help us tackle illegal fishing?_ - [https://www.weforum.org/agenda/2017/05/can-technology-help-tackle-illegal-fishing/](https://www.weforum.org/agenda/2017/05/can-technology-help-tackle-illegal-fishing/)
+   _IUU Tuna Traceability Declaration Launched at the Ocean Conference_ - [https://www.nature.org/newsfeatures/pressreleases/iuu-tuna-traceability-declaration-launched-at-oceans-conference.xml](https://www.nature.org/newsfeatures/pressreleases/iuu-tuna-traceability-declaration-launched-at-oceans-conference.xml)
+   Dominic Waughray, _Tuna 2020 Traceability Declaration: Stopping illegal tuna from coming to market_ - [https://www.weforum.org/agenda/2017/06/tuna-2020-traceability-declaration-stopping-illegal-tuna-from-coming-to-market/](https://www.weforum.org/agenda/2017/06/tuna-2020-traceability-declaration-stopping-illegal-tuna-from-coming-to-market/)
+   Hyperledger Sawtooth - [https://sawtooth.hyperledger.org/docs/core/releases/latest/architecture/journal.html](https://sawtooth.hyperledger.org/docs/core/releases/latest/architecture/journal.html) and [https://sawtooth.hyperledger.org/docs/core/releases/latest/architecture.html](https://sawtooth.hyperledger.org/docs/core/releases/latest/architecture.html)

### Chapter 7. Introduction to Hyperledger Fabric

+   Nishan Degnarain, _Can technology help us tackle illegal fishing?_ - [https://www.weforum.org/agenda/2017/05/can-technology-help-tackle-illegal-fishing/](https://www.weforum.org/agenda/2017/05/can-technology-help-tackle-illegal-fishing/)
+   _IUU Tuna Traceability Declaration Launched at the Ocean Conference_ - [https://www.nature.org/newsfeatures/pressreleases/iuu-tuna-traceability-declaration-launched-at-oceans-conference.xml](https://www.nature.org/newsfeatures/pressreleases/iuu-tuna-traceability-declaration-launched-at-oceans-conference.xml)
+   Dominic Waughray, _Tuna 2020 Traceability Declaration: Stopping illegal tuna from coming to market_ - [https://www.weforum.org/agenda/2017/06/tuna-2020-traceability-declaration-stopping-illegal-tuna-from-coming-to-market/](https://www.weforum.org/agenda/2017/06/tuna-2020-traceability-declaration-stopping-illegal-tuna-from-coming-to-market/)
+   Hyperledger Fabric Documentation - [https://hyperledger-fabric.readthedocs.io/en/latest/](https://hyperledger-fabric.readthedocs.io/en/latest/)

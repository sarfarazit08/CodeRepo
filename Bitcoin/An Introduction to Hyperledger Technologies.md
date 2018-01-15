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

# Chapter 4. Technical Requirements

## Introduction & Learning Objectives
## Installation Instructions for Linux
## Installation Instructions for MacOS
## Installation Instructions for Windows

# Chapter 5. Introduction to Hyperledger Iroha

## Introduction & Learning Objectives
## Key Components
## Joining the Hyperledger Iroha Community

# Chapter 6. Introduction to Hyperledger Sawtooth
    
## Introduction & Learning Objectives
## Addressing Illegal, Unregulated, and Unreported Tuna Fishing (Demonstrated Scenario)
## Key Components and Transaction Flow
## Installing Hyperledger Sawtooth
## Writing an Application
## Joining the Hyperledger Sawtooth Community
        
# Chapter 7. Introduction to Hyperledger Fabric
    
## Introduction & Learning Objectives
## Addressing Illegal, Unregulated, and Unreported Tuna Fishing (Demonstrated Scenario)
## Key Components and Transaction Flow
## Installing Hyperledger Fabric
## Understanding Chaincode
## Chaincode Walkthrough (Demonstrated Scenario)
## Writing an Application
## Joining the Hyperledger Fabric Community

# Chapter 8. What's Next?

## What's Next?

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

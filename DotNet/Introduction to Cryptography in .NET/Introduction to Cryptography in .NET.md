# Introduction to Cryptography in .NET

## Outline

1. Definitions
2. Brief History
3. Why Cryptography?
4. Things to Consider

+ Stenography - Hide Message
    + Invisisble inks 
    + Pin pointing relevant letters in a news paper
    + Message written after shaving head and then let the hair grow to hide it
+ Cryptology
    1. ***Cryptography***: Science of keeping messages secure
    2. ***Cryptanalysis***: Science of breaking secure messages

> Note: There is constant battle going on between Cryptography and Cryptanalysis. Both the fields are constantly innovating back and forth the ways to secure a message and break it.

### Terms
+ ***Plain Text***: Original Data
+ ***Cipher Text***: Encrypted Data
+ ***Encryption***: Process of Obscuring Data
+ ***Decryption***: Process of Recovering Original Data from Encrypted Data

### Brief History
+ [Spartan Scytale](https://www.youtube.com/watch?v=1tA0WO6LMqY)
+ [Ceasar Cipher](https://www.youtube.com/watch?v=sMOZf4GN3oc)
+ [Substitution Cipher](https://www.youtube.com/watch?v=1P8Xpxm76e8)
+ [Vigenere Cipher]()
+ [German Enigma]()
+ [DES - ]()
+ [Advanced Encryption Standard(AES)]()
+ [Public Key Cryptography (RSA)]()

### Why Cryptography?

+ ***Confidentiality***: Protect dat from being read
+ ***Integrity***: Verify that data was not modified
+ ***Authentication***: Identify and validate a user
+ ***Non-repudiation***: Sender can't deny later that he sent a message

### Things to Consider

+ What is your goal? (Confidentiality, Authentication...etc.)
+ How much us data worth?
+ How long does it need to be secured?
+ What are the primary threats?
    + In Transit
    + Access to Web Assets
    + Deump Of Memory
    + Modify PAges
    + Reverse Engineer Assemblies
    + ...
+ Company Security Policies
+ Regulatory Compliance
+ Layered Defences, How many are enough?

### Summary

+ Cryptology
    1. ***Cryptography***: Science of keeping messages secure
    2. ***Cryptanalysis***: Science of breaking secure messages
+ Know what you're trying to do
    + ***Confidentiality***: Protect dat from being read
    + ***Integrity***: Verify that data was not modified
    + ***Authentication***: Identify and validate a user
    + ***Non-repudiation***: Sender can't deny later that he sent a message
+ Consider what an attacker might try or be able to do
+ We're going to use ***`System.Security.Cryptography`*** class for this
+ **Don't write your own**

# 01 - Hashing

## Outline

+ Hash Function Definition
+ Common Hash Functions/Algorithms
+ Tamperproof Querystrings
+ Hashed Passwords
+ Salted Passwords
+ Hashing in ASP.NET

### Hash Function Definition

+ Converts a variable length input to a fixed lenght output (called : **Digest**)
+ It's a one way process, easier to compute but can't be reversed.

### Common Hash Functions/Algorithms

+ MD5(128 bit hash)
+ SHA(Secure Hash Algorithm)
    + SHA1(160 bit hash)
    + SHA256(256 bit hash)
    + SHA384(384 bit hash)
    + SHA512(512 bit hash)
+ Keyed Hash Algorithm (Message Authentication Code)
    + HMACSHA*
    + MACTripleDES

### Tamperproof Querystrings

+ Goal is to protect integrity of querystring
+ Use a Hash based Message Authentication Code (HMAC)
    + Compute the hash of a querystring when constructed
    + validate querystring was not modified by computing hash with querystring and comparing to original hash
    + Uses a key to ensure that attacker could not create own valid hash

### Hashed Passwords

+ Considered best practice for passwords since they cannot be retrieved
+ Used for authentication
+ Common attack against hashed passwords is ***`Dictionary Attack`***

### Salted Passwords

+ Add some unique random data (called : **salt**) to each password
+ Greatly increases work required to mount a dictionary attack against all passwords, need to pre-compute dictionary hash values for all salt values
+ Note: This does nothing to increase the security for an individual password if **`Salt`** is easily found. (Add **Entropy** to do this.)

### Hashing in ASP.NET

+ ViewState MAC
+ ASP.NET Membership
+ Minification and Bundling

### Summary

+ Used to provide integrity and authentication
+ Create a fixed length "Digest" from variable length data
+ Used to protect integrity of Querystrings
+ Commonly used with password systems

# 02 - Symmetric Algorithms

## Outline

+ Symmetric Algorithms Definition
+ Common Symmetric Algorithms
+ How Symmetric Algorithms Work?
+ CryptoStream
+ Symmetric Encryption in ASP.NET

### Symmetric Algorithm Definition

+ Encryption and Decryption use the same secret key
+ Primary attack is **`Brute Force`** key search
+ Key distribution and storage is difficult
+ Relatively Fast
 
##### Advanced Encryption Standard(AES)

+ US government standard since 2001 (replaced DES)
+ Rijndael (with 128 bit block size)
+ Well supported by encryption libraries

### Common Symmetric Algorithms

+ Abstract Class Symmetric Algorithms
    + Rijndael/AES
    + TripleDES
    + DES
    + RC2
+ Other AES finalists(not in .NET framework library)
    + Mars
    + RC6
    + Serpent
    + TwoFish

### How Symmetric Algorithms Work?

+ .NET symmetric algorithms are "block ciphers"
    + Padding - data added to fill to block size
    + Zeros
    + PKCS7
    + ISO10126(recommended)
+ Mode
    + ECB
    + CBC(recommended)
+ Initialization Vector(IV)
    + Random data used to seed first block
    + Does not need to be secret
    + Never reuse, always use unique for each set of data

### CryptoStream

+ Integrate encryption and decryption with .NET Streams (not stream ciphers)
+ Chain streams to have opertations performed in particular order

### Symmetric Encryption in ASP.NET

+ ViewState
+ Forms Authentication
+ Anonymous Identification
+ Role Cookies

### Summary

+ Symmertric Algorithms
+ Provide confidentiality
+ Use a secret shared key for encryption and decryption
+ Faster Encryption and Decryption
+ Secure Key storage is difficult
+ Key distribution is problematic


# 03 - Asymmetric Algorithms

## Outline

+ Asymmetric Algorithms Definition
+ Common Asymmetric Algorithms
+ How to generate keys?
+ Safely encrypting a Web Site

### Asymmetric Algorithm Definition

+ Also called **"Public Key Cryptography"**
+ Utilizes two complimentary keys
    + Public key
    + Private Key
+ Generally 100 to 1000 times slower than symmetric algorithms
+ Often use asymmetric to encrypt a "session" symmetric key

### Common Asymmetric Algorithms

+ RSA
+ DSA (Digital Signatures Only)
+ ECDiffieHellman

### Safely encrypting a Web Site

+ Generate an RSA Key Pair
    + Store only the public key on web servers
    + Store the private key on an Internal Secured System that needs the data    
+ Encrypt directly for small amount of data
+ Encrypt a symmetric key, use it to encrypt larger data (as it's faster)

### Summary

+ Provide confidentiality
+ Use a public/private key pair
+ Slower Encryption and Decryption than Sysmmetric Algorithms
+ Often used to encrypt a symmetric "session" key
+ Key distribution is problematic


# 04 - Digital Signatures

## Outline

+ Digital Signatures
+ Protecting Configuration Sections
+ Key Sizes and Storage
+ Other .NET Cryptography
+ Digital Certificates and PKI
+ SSL/TLS

### Digital Signatrues

+ Provide integrity and non-repudiation
+ Hash the content of a message, sign it (encrypt) with senders private key
+ By default, does not provide confidentiality, can encrypt with reciever's public key befor signing

***<Figure>***

# 05 - Protect Config Sections

+ Encrypt sections of the web.config, auto decrypted by ASP.NET as needed
+ Sections that can't encrypt(processModel, runtime, mscorlib, startup, etc.)
+ Machine Level and User Level Keys
+ Two Options: 
    + DPAPI (Data Protection Configuration Provider)
    + RSA

### Encryption With DPAPI

+ OS level pair of functions since Windows Server 2000 and XP
+ Machine Specific Keys Used
+ Easier to use for a particular Server
+ Can't use the encrypted section on another machine
    + E.g., Use of ***aspnet_regiis*** to encrypt a section

### Encryption With RSA

+ Best choice for web forms (encrypted section can be used on multiple servers)
+ How to do it :
    + Server 1
        + Generate RSA Key Pair
        + Setup a local ***web.config*** provider for custom key pair
        + encrypt the section with ***aspnet_regiis***
        + Grant access to ***Network Service***
        + Export the key pair
    + Server 2
        + Import the key pair
        + Grant access to ***Network Service***

# 06 - Key Sizes & Storage

### Key Sizes

+ Tradeoff performance and security
+ Symmetric Rijndael Managed (AES) use 256 bits
+ Asymmetric RSA use 2048 or 4096

### Key

+ Hardcoded strings are visisble if use a dissembler (like ILDASM)
+ Encrypted ***<appSetting>*** section of ***web.config***
+ Split key in code, registry, and config files
+ Remote Service

### Generating keys
### Regenerate Periodically

# 07 - Other .NET Cryptography

+ XML Encryption
    + System.Security.Cryptography.Xml
+ Enterprise Library - Cryptography Application Block
    + Supports hashing and symmetric encryption
+ In Memory Encryption
    + Secure String
    + ProtectedMemory, ProtectedData
+ Additional .NET Classes
    + Cryptography API : Next Generation (CNG) - end in ***Cng***
    + CryptoAPI - end in ***CryptoServiceProvider***
+ Cryptography strong random numbers
    + RNGCryptoServiceProvider


# 08 - Digital Certificates and PKI

## Digital Certificate

+ Public key associated with a particular entity (person, company)
+ X.509 format
    + Issuer
    + Validity Period
    + Public Key
    + Signature (from the issuer)
+ Helps Validate someone's public key
+ E.g., SSL/TLS

## Public Key Infrastructure (PKI)

+ Certificate Authority(CA) - Digitally signs a public key
+ Browsers know public keys of CAs so they can validate signatures attached to digital certificates

### SSL/TLS

+ TLS (Transport Layer Security)
+ SSL (Secure Socket Layer)

#### Web Server (provider)

+ Generates public/private key pair
+ Submits public key to CA with identification (can self-sign)

+ Client can validate that server certificate was signed by well-known CA (asymmetric) and that domain stored in certificate mathces
+ Client and Server use a newly created shared key for encryption (symmetric)

+ **Fiddler** can be used to decrypt ***SSL trafic***

### Summary

+ Use trusted algorithms and implementations
+ Use hashing to validate the integrity of data or to prove both know the same secret
+ Use symmetric algorithms unless have special needs for asymmetric (digital signatures, etc.)
+ Know threats and choose the proper countermeasures

# 09 - Resources

## Books

+ Applied Cryptography - Bruce Schneier
+ Cryptography Engineering - Ferguson, Schneier, Kohno
+ Understanding Cryptography - Paar, Pelzl
+ The Code Book - Simon Singh
+ The Code Breakers - Kahn

## Code Demo Videos

10, 12, 14, 16, 18, 24, 26, 28, 30, 32, 34, 38, 41, 43
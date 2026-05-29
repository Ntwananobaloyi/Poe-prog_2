using System.Collections;

namespace Poe_2
{ //star of namespace 
    public  class responses
    { //start of class
        private object reply;
        private object ignore;

        public responses(object reply, object ignore)
        {//start of constructor 
            this.reply = reply;
            this.ignore = ignore;
        }//end of constructor

        //method to store the list of words
        private void words(ArrayList ignoring)
        {//
         //ignoring questions
            ignoring.Add("a");
            ignoring.Add("about");
            ignoring.Add("above");
            ignoring.Add("across");
            ignoring.Add("after");
            ignoring.Add("afterwards");
            ignoring.Add("again");
            ignoring.Add("against");
            ignoring.Add("all");
            ignoring.Add("almost");
            ignoring.Add("alone");
            ignoring.Add("along");
            ignoring.Add("already");
            ignoring.Add("also");
            ignoring.Add("although");
            ignoring.Add("always");
            ignoring.Add("am");
            ignoring.Add("among");
            ignoring.Add("amongst");
            ignoring.Add("amount");
            ignoring.Add("an");
            ignoring.Add("and");
            ignoring.Add("another");
            ignoring.Add("any");
            ignoring.Add("anyhow");
            ignoring.Add("anyone");
            ignoring.Add("anything");
            ignoring.Add("anyway");
            ignoring.Add("anywhere");
            ignoring.Add("are");
            ignoring.Add("around");
            ignoring.Add("as");
            ignoring.Add("at");
            ignoring.Add("back");
            ignoring.Add("be");
            ignoring.Add("became");
            ignoring.Add("because");
            ignoring.Add("become");
            ignoring.Add("becomes");
            ignoring.Add("becoming");
            ignoring.Add("been");
            ignoring.Add("before");
            ignoring.Add("beforehand");
            ignoring.Add("behind");
            ignoring.Add("being");
            ignoring.Add("below");
            ignoring.Add("beside");
            ignoring.Add("besides");
            ignoring.Add("between");
            ignoring.Add("beyond");
            ignoring.Add("both");
            ignoring.Add("but");
            ignoring.Add("by");
            ignoring.Add("can");
            ignoring.Add("cannot");
            ignoring.Add("could");
            ignoring.Add("did");
            ignoring.Add("do");
            ignoring.Add("does");
            ignoring.Add("doing");
            ignoring.Add("done");
            ignoring.Add("down");
            ignoring.Add("during");
            ignoring.Add("each");
            ignoring.Add("either");
            ignoring.Add("else");
            ignoring.Add("elsewhere");
            ignoring.Add("enough");
            ignoring.Add("etc");
            ignoring.Add("even");
            ignoring.Add("ever");
            ignoring.Add("every");
            ignoring.Add("everyone");
            ignoring.Add("everything");
            ignoring.Add("everywhere");
            ignoring.Add("except");
            ignoring.Add("few");
            ignoring.Add("first");
            ignoring.Add("for");
            ignoring.Add("former");
            ignoring.Add("formerly");
            ignoring.Add("from");
            ignoring.Add("further");
            ignoring.Add("had");
            ignoring.Add("has");
            ignoring.Add("have");
            ignoring.Add("having");
            ignoring.Add("he");
            ignoring.Add("hence");
            ignoring.Add("her");
            ignoring.Add("here");
            ignoring.Add("hereafter");
            ignoring.Add("hereby");
            ignoring.Add("herein");
            ignoring.Add("hereupon");
            ignoring.Add("hers");
            ignoring.Add("herself");
            ignoring.Add("him");
            ignoring.Add("himself");
            ignoring.Add("his");
            ignoring.Add("how");
            ignoring.Add("however");
            ignoring.Add("i");
            ignoring.Add("if");
            ignoring.Add("in");
            ignoring.Add("indeed");
            ignoring.Add("inside");
            ignoring.Add("instead");
            ignoring.Add("into");
            ignoring.Add("is");
            ignoring.Add("it");
            ignoring.Add("its");
            ignoring.Add("itself");
            ignoring.Add("last");
            ignoring.Add("later");
            ignoring.Add("latter");
            ignoring.Add("latterly");
            ignoring.Add("least");
            ignoring.Add("less");
            ignoring.Add("lot");
            ignoring.Add("many");
            ignoring.Add("may");
            ignoring.Add("me");
            ignoring.Add("meanwhile");
            ignoring.Add("might");
            ignoring.Add("more");
            ignoring.Add("moreover");
            ignoring.Add("most");
            ignoring.Add("mostly");
            ignoring.Add("much");
            ignoring.Add("must");
            ignoring.Add("my");
            ignoring.Add("myself");
            ignoring.Add("name");
            ignoring.Add("namely");
            ignoring.Add("neither");
            ignoring.Add("never");
            ignoring.Add("nevertheless");
            ignoring.Add("next");
            ignoring.Add("no");
            ignoring.Add("nobody");
            ignoring.Add("none");
            ignoring.Add("noone");
            ignoring.Add("nor");
            ignoring.Add("not");
            ignoring.Add("nothing");
            ignoring.Add("now");
            ignoring.Add("nowhere");
            ignoring.Add("of");
            ignoring.Add("off");
            ignoring.Add("often");
            ignoring.Add("on");
            ignoring.Add("once");
            ignoring.Add("one");
            ignoring.Add("only");
            ignoring.Add("or");
            ignoring.Add("other");
            ignoring.Add("others");
            ignoring.Add("otherwise");
            ignoring.Add("ought");
            ignoring.Add("our");
            ignoring.Add("ours");
            ignoring.Add("ourselves");
            ignoring.Add("out");
            ignoring.Add("outside");
            ignoring.Add("over");
            ignoring.Add("own");
            ignoring.Add("part");
            ignoring.Add("per");
            ignoring.Add("perhaps");
            ignoring.Add("please");
            ignoring.Add("put");
            ignoring.Add("rather");
            ignoring.Add("re");
            ignoring.Add("same");
            ignoring.Add("see");
            ignoring.Add("seem");
            ignoring.Add("seemed");
            ignoring.Add("seeming");
            ignoring.Add("seems");
            ignoring.Add("several");
            ignoring.Add("she");
            ignoring.Add("should");
            ignoring.Add("show");
            ignoring.Add("side");
            ignoring.Add("since");
            ignoring.Add("so");
            ignoring.Add("some");
            ignoring.Add("somehow");
            ignoring.Add("someone");
            ignoring.Add("something");
            ignoring.Add("sometime");
            ignoring.Add("sometimes");
            ignoring.Add("somewhere");
            ignoring.Add("still");
            ignoring.Add("such");
            ignoring.Add("take");
            ignoring.Add("than");
            ignoring.Add("that");
            ignoring.Add("the");
            ignoring.Add("their");
            ignoring.Add("theirs");
            ignoring.Add("them");
            ignoring.Add("themselves");
            ignoring.Add("then");
            ignoring.Add("thence");
            ignoring.Add("there");
            ignoring.Add("thereafter");
            ignoring.Add("thereby");
            ignoring.Add("therefore");
            ignoring.Add("therein");
            ignoring.Add("thereupon");
            ignoring.Add("these");
            ignoring.Add("they");
            ignoring.Add("this");
            ignoring.Add("those");
            ignoring.Add("though");
            ignoring.Add("through");
            ignoring.Add("throughout");
            ignoring.Add("thru");
            ignoring.Add("thus");
            ignoring.Add("to");
            ignoring.Add("together");
            ignoring.Add("too");
            ignoring.Add("toward");
            ignoring.Add("towards");
            ignoring.Add("under");
            ignoring.Add("unless");
            ignoring.Add("until");
            ignoring.Add("up");
            ignoring.Add("upon");
            ignoring.Add("us");
            ignoring.Add("used");
            ignoring.Add("very");
            ignoring.Add("via");
            ignoring.Add("was");
            ignoring.Add("we");
            ignoring.Add("well");
            ignoring.Add("were");
            ignoring.Add("what");
            ignoring.Add("whatever");
            ignoring.Add("when");
            ignoring.Add("whence");
            ignoring.Add("whenever");
            ignoring.Add("where");
            ignoring.Add("whereafter");
            ignoring.Add("whereas");
            ignoring.Add("whereby");
            ignoring.Add("wherein");
            ignoring.Add("whereupon");
            ignoring.Add("wherever");
            ignoring.Add("whether");
            ignoring.Add("which");
            ignoring.Add("while");
            ignoring.Add("whither");
            ignoring.Add("who");
            ignoring.Add("whoever");
            ignoring.Add("whole");
            ignoring.Add("whom");
            ignoring.Add("whose");
            ignoring.Add("why");
            ignoring.Add("will");
            ignoring.Add("with");
            ignoring.Add("within");
            ignoring.Add("without");
            ignoring.Add("would");
            ignoring.Add("yes");
            ignoring.Add("yet");
            ignoring.Add("hey");
            ignoring.Add("you");
            ignoring.Add("your");
            ignoring.Add("yours");
            ignoring.Add("yourself");
            ignoring.Add("yourselves");

        }//

        public void answers(ArrayList add_answers)
        {//start of method
            add_answers.Add("greeting i'm doing well, thanks for asking! how are you doing today ?");
            add_answers.Add("greeting i'm great today, thanks for asking! how can i help you today ?");
            add_answers.Add("greeting doing good! hope you are also doing well today ?");


            add_answers.Add("purpose my purpose is to educate you on how to stay safe online and guide your cybersecurity questions.");
            add_answers.Add("purpose i help users understand online safety and digital protection.");
            add_answers.Add("purpose i assist with cybersecurity awareness and safety guidance.");


            add_answers.Add("cybersecurity cybersecurity is the practice of protectingcomputers, networks and data from cyber threats.");
            add_answers.Add("cybersecurity involves tools and methods used to prevent hacking, data, theft and online attacks.");
            add_answers.Add("cybersecurity is the protection of digital systems and information from unauthorized access or damage.");


            add_answers.Add("phishing is a scam where criminals pretend to be trustworthy to steal personal information.");
            add_answers.Add("phishing is a cyberattack that uses fake emails, messages or websites to trick users into revealing sensitive information.");
            add_answers.Add("phishing is the act of deceving users online in order to gain access to confidential information.");


            add_answers.Add("firewall is a security system that blocks harmful traffic from entering a network or device.");
            add_answers.Add("firewall monitors and controls incoming and outgoing internet connections for protection.");
            add_answers.Add("firewall it acts like a digital barrier between trusted devices and cyber threats.");


            add_answers.Add("password a password is used to secure access to your accounts or devices.");
            add_answers.Add("password is a security key that confirms a users identity before access is allowed.");
            add_answers.Add("password is a private combination of letters, numbers or symbols used for login protection.");


            add_answers.Add("hacked account occurs when cybercriminals gain control of someones account illegally.");
            add_answers.Add("hacked account is an online account that has been accessed without the owners permission.");
            add_answers.Add("hacked account enable extra security like two-factor authentication.");


            add_answers.Add("fraud is the act of deceiving someone for money, personal gain or illegal benefit.");
            add_answers.Add("fraud is dishonest activity intended to trick people or organisation.");
            add_answers.Add("fraud is a crime where false information or deception is used to gain something unfairly.");


            add_answers.Add("malicious means harmful or intended to cause damage, especially in cyberattacks.");
            add_answers.Add("malicious describes software or actions designed to steal, destroy or disrupt.");
            add_answers.Add("malicious refers to dangerous online activity carried out with harmful intent.");


            add_answers.Add("vpn (Virtual Private Network) is a tool that protects internet activity by creating a secure connection.");
            add_answers.Add("vpn hides a users online location and encrypts their internet traffic for privacy.");
            add_answers.Add("vpn is a secure network service that helps keep online data safe from hackers.");




            //sentiment detection

            add_answers.Add("frustrated i understand you're frustrated. let's work through the issue step by step.");
            add_answers.Add("frustrated it's okay to feel frustrated when things aren't working. i'm here to help.");
            add_answers.Add("frustrated take a breath, we'll fix this together.");


            add_answers.Add("confused that's okay, confusion is normal. i'll explain it clearly for you.");
            add_answers.Add("confused let me break it down step by step so it makes sense.");
            add_answers.Add("confused no worries, i'll help you understand it better.");


            add_answers.Add("worried it's okay to feel worried. i'm here to help you stay safe online.");
            add_answers.Add("worried don't panic, most cybersecurity issues can be fixed quickly.");
            add_answers.Add("worried i understand your concern. let's make sure your information is safe.");


            add_answers.Add("happy that's great to hear! i'm glad things are going well.");
            add_answers.Add("happy awesome! positivity is always good.");
            add_answers.Add("happy i'm happy for you! let me know if you need anything.");


            add_answers.Add("sad i'm sorry you're feeling this way. i'm here for you.");
            add_answers.Add("sad that sounds tough, take things one step at a time.");
            add_answers.Add("sad i hope things improve soon. you can talk to me anytime.");


            add_answers.Add("angry i understand you're angry. let's try solve the issue together.");
            add_answers.Add("angry it's okay to feel angry, but i'll help you fix the problem.");
            add_answers.Add("angry take your time, i'm here to help you sort it out.");

        }//end of method 
    }//end of class 
}//end of namespace
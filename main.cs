   person currentPartner = person.byName("xxx", "xxx");   
   if (me.with(currentPartner)) {
    if (currentPartner.getAttentionTarget() == me) {
     if (env.getDayPart() == daypart.DAYPART_NIGHT) {
      new Task(() => {
       while(me.getStamina() >= stamina.CAPABLE
       && currentPartner.getStamina() >= stamina.CAPABLE) {
        int myHotnessLevel = me.getHotnessLevel();
        if (myHotnessLevel < 2) {
         me.talkTo(currentPartner);
         continue;
        }
        if (myHotnessLevel < 3 || myHotnessLevel >= 9) {
         me.expectWords(currentPartner, dictionary_type.NICE_THINGS, 30);
         continue;
        }
        if (myHotnessLevel >= 3) {
         me.hug(currentPartner);
        }
        if (myHotnessLevel >= 4) {
         me.kiss(currentPartner);
        }
        if (myHotnessLevel >= 5) {
         me.caress(currentPartner);
        }
        if (myHotnessLevel >= 8) {
         me.makeLove(currentPartner);
         if (me.getOxytocinLevel() == hormone_level.HIGH) {
          me.say(dictionary_type.LOVE_YOU);
         } else {
          me.say(dictionary_type.LIKE_YOU);
         }
        }
       }
       me.say(dictionary_type.NICE_THINGS).sleep();
      });
     }
    }
   }

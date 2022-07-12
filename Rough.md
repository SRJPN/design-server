- Class - to store the values
    Store 
        - designContent
        - designId
        - userId 


/** Returns a list of design ids that the given context has access to. */
List<String> findDesigns(AuthContext ctx);


DesignContent
{
    id
    content
}


user {
    userId
}

User_DesignContent_relation
 {
     DesignContent_id
     user_id
 }